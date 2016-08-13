using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace namecard_book
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        string filePath = AppDomain.CurrentDomain.BaseDirectory;
        // 저장 파일
        string fileName = "book.txt";
        // 리스트1 (전체 데이터)
        List<DataBin> peopleList = new List<DataBin>();
        // 리스트2 (검색 데이터)
        List<DataBin> search_data = new List<DataBin>();
        // 검색 데이터 판단 여부
        bool searching = false;
        // loading 데이터 temp bin
        DataBin loaded_data = new DataBin();

        public MainWindow()
        {
            InitializeComponent();

            if(!File.Exists(filePath + fileName))
            {
                // 저장된 파일이 없으면 생성
                File.WriteAllText(filePath + fileName, "");
                result_TextBlock.Text = "저장된 데이터가 없습니다!";
            }
            else
            {
                // 저장된 파일 로드
                LoadData();
            }

        }

        void LoadData()
        {
            StreamReader sr = new StreamReader(filePath + fileName);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string check = line;
                // '/' 를 구분 기호로 하여 데이터 로드 후 tempList에 넣기
                List<string> tempList = check.Split('/').ToList();

                DataBin item = new DataBin();

                int index = 0;

                foreach(string each in tempList)
                {
                    // 순서대로 집어 넣기
                    if (index == 0) item.Id = each;
                    if (index == 1) item.Name = each;
                    if (index == 2) item.Position = each;
                    if (index == 3) item.Company = each;
                    if (index == 4) item.Address = each;
                    if (index == 5) item.Tel = each;
                    if (index == 6) item.EMail = each;

                    index++;
                }

                // 한 줄에 한 데이터이므로 people리스트에 넣어 줌
                peopleList.Add(item);

            }
            // people_ListView Binding                  
            people_ListView.ItemsSource = peopleList;

        }

        private bool alertMessage()
        {
            bool checker = true;

            result_TextBlock.Text = "";

            if (name_TextBox.Text.Equals(""))
            {
                result_TextBlock.Text += "이름을 입력하세요!" +Environment.NewLine;
                checker = false;
            }
            if (position_TextBox.Text.Equals(""))
            {
                result_TextBlock.Text += "직급을 입력하세요!" + Environment.NewLine;
                checker = false;
            }
            if (tel_TextBox.Text.Equals(""))
            {
                result_TextBlock.Text += "전화번호를 입력하세요!" + Environment.NewLine;
                checker = false;
            }
            if (address_TextBox.Text.Equals(""))
            {
                result_TextBlock.Text += "주소를 입력하세요!" + Environment.NewLine;
                checker = false;
            }
            if (company_TextBox.Text.Equals(""))
            {
                result_TextBlock.Text += "회사를 입력하세요!" + Environment.NewLine;
                checker = false;
            }
            if (email_TextBox.Text.Equals(""))  {
                result_TextBlock.Text += "이메일을 입력하세요!" + Environment.NewLine;
                checker = false;
            }

            return checker;
        }

        private void modify_button_click(object sender, RoutedEventArgs e)
        {
            // 입력 및 수정 업데이트 

            if(loaded_data.Id == null)
            {
                // 최초 입력
                // loaded_data.Id 가 없다면..
                
                DataBin item = new DataBin();
                item.Name = name_TextBox.Text;
                item.Position = position_TextBox.Text;
                item.Tel = tel_TextBox.Text;
                item.Address = address_TextBox.Text;
                item.Company = company_TextBox.Text;
                item.EMail = email_TextBox.Text;

                bool check_message = alertMessage();

                if (!check_message)
                {
                    return;
                }
                else
                {
                    string idCheck = "";

                    int idcount = peopleList.Count + 1;
                    idCheck = idcount.ToString();

                    item.Id = idCheck;

                    peopleList.Add(item);



                    result_TextBlock.Text = "새로운 데이터가 입력되었습니다!";
                }

               

            }
            else
            {
                // 실제 자료
                // 수정하여 업데이트
                bool check_message = alertMessage();

                if (!check_message)
                {
                    return;
                }
                else
                {
                    foreach (DataBin item in peopleList)
                    {
                        if (item.Id.Equals(loaded_data.Id))
                        {
                            item.Name = name_TextBox.Text;
                            item.Position = position_TextBox.Text;
                            item.Tel = tel_TextBox.Text;
                            item.Address = address_TextBox.Text;
                            item.Company = company_TextBox.Text;
                            item.EMail = email_TextBox.Text;
                        }
                    }

                    result_TextBlock.Text = "수정이 완료되었습니다!";
                }

            }

            string check = "";

            foreach (DataBin item in peopleList)
            {
               check += item.Id+"/"+item.Name + "/" + item.Position + "/" + item.Tel + "/" + item.Address + "/" + item.Company + "/" + item.EMail + Environment.NewLine;

            }

            // 저장해 줌. 실제로는 Write보다 Append를 쓰고, 삭제시에는 Id 값을 찾아서 삭제하는 것이 더 바람직할 듯

            File.WriteAllText(filePath + fileName, check);

            name_TextBox.Text = "";
            position_TextBox.Text = "";
            tel_TextBox.Text = "";
            address_TextBox.Text = "";
            company_TextBox.Text = "";
            email_TextBox.Text = "";
            loaded_data = new DataBin();

            listing();

        }

        private void delete_button_click(object sender, RoutedEventArgs e)
        {
            if(loaded_data.Id != null)
            {
                for(int k = 0; k < peopleList.Count; k++)
                {
                    if (peopleList[k].Id.Equals(loaded_data.Id))
                    {
                        peopleList.RemoveAt(k);
                        result_TextBlock.Text = "선택 데이터를 삭제했습니다!";
                        k--;
                    }
                }
            }
            else
            {
                result_TextBlock.Text = "아직 입력하지 않은 데이터입니다!";
            }
                        

            string check = "";

            // 자료를 삭제할 때마다 매번 id 값을 새로 부여해 줌.
            // List에 들어간 크기보다 +1로 id 값을 부여하면 나중에 숫자가 겹치게 됨.
            // 실제로는 Random 등을 사용해서 Id값을 부여해 주는 것이 더 바람직할 듯.
            int id = 1;

            foreach (DataBin item in peopleList)
            {
                check += id +"/"+ item.Name + "/" + item.Position + "/" + item.Tel + "/" + item.Address + "/" + item.Company + "/" + item.EMail + Environment.NewLine;
                id++;
            }

            listing();

            name_TextBox.Text = "";
            position_TextBox.Text = "";
            tel_TextBox.Text = "";
            address_TextBox.Text = "";
            company_TextBox.Text = "";
            email_TextBox.Text = "";
            loaded_data = new DataBin();

            File.WriteAllText(filePath + fileName, check);
        }

        void listing()
        {
            // 서치를 했을 때와, 아닐 때 리스트뷰 바인딩의 소스가 달라야 하므로..

            if (searching)
            {
                // 검색 중이라면..

                search_data.Clear();

                string search_text = search_TextBox.Text;

                // 검색창에 있는 단어 중 하나라도 포함하면 보여 줌

                foreach (DataBin item in peopleList)
                {
                    if (item.Name.Contains(search_text) ||
                        item.Position.Contains(search_text) ||
                         item.Tel.Contains(search_text) ||
                          item.Address.Contains(search_text) ||
                           item.Company.Contains(search_text) ||
                            item.EMail.Contains(search_text))
                    {
                        search_data.Add(item);
                    }
                }

                people_ListView.ItemsSource = null;
                people_ListView.ItemsSource = search_data;
            }
            else
            {
                // 검색 중이 아니라면 원본 리스트뷰를 보여줌..

                people_ListView.ItemsSource = null;
                people_ListView.ItemsSource = peopleList;
            }
        }

        private void search_Button_clicked(object sender, RoutedEventArgs e)
        {
            // 서치 버튼을 클릭했을 때

            string type = ((Button)sender).Content.ToString();

            if (type.Contains("검색"))
            {
                search_data.Clear();

                searching = true;
                string search_text = search_TextBox.Text;

                foreach (DataBin item in peopleList)
                {
                    if(item.Name.Contains(search_text) ||
                        item.Position.Contains(search_text) ||
                         item.Tel.Contains(search_text) ||
                          item.Address.Contains(search_text) ||
                           item.Company.Contains(search_text) ||
                            item.EMail.Contains(search_text))
                    {
                        search_data.Add(item);
                    } 
                }

                people_ListView.ItemsSource = null;
                people_ListView.ItemsSource = search_data;
            }
            else
            {
                searching = false;

                people_ListView.ItemsSource = null;
                people_ListView.ItemsSource = peopleList;
            }

            
        }

        private void item_selected(object sender, MouseButtonEventArgs e)
        {
            // 리스트뷰 아이템 로드

            ListViewItem check = (ListViewItem)sender;

            DataBin selectedItem = (DataBin)check.DataContext;

            name_TextBox.Text = selectedItem.Name;
            position_TextBox.Text = selectedItem.Position;
            tel_TextBox.Text = selectedItem.Tel;
            address_TextBox.Text = selectedItem.Address;
            company_TextBox.Text = selectedItem.Company;
            email_TextBox.Text = selectedItem.EMail;

            loaded_data = selectedItem;

        }
    }
}
