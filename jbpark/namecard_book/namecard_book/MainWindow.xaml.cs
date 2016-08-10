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
        string fileName = "book.txt";
        List<DataBin> peopleList = new List<DataBin>();
        List<DataBin> search_data = new List<DataBin>();
        bool searching = false;
        DataBin loaded_data = new DataBin();

        public MainWindow()
        {
            InitializeComponent();

            if(!File.Exists(filePath + fileName))
            {
                File.WriteAllText(filePath + fileName, "");
                result_TextBlock.Text = "저장된 데이터가 없습니다!";
            }
            else
            {
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
                List<string> tempList = check.Split('/').ToList();

                DataBin item = new DataBin();

                int index = 0;

                foreach(string each in tempList)
                {
                    if (index == 0) item.Id = each;
                    if (index == 1) item.Name = each;
                    if (index == 2) item.Position = each;
                    if (index == 3) item.Company = each;
                    if (index == 4) item.Address = each;
                    if (index == 5) item.Tel = each;
                    if (index == 6) item.EMail = each;

                    index++;
                }

                peopleList.Add(item);

            }                  
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
            if(loaded_data.Id == null)
            {
                // 최초 입력
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
            if (searching)
            {
                search_data.Clear();

                string search_text = search_TextBox.Text;

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
                people_ListView.ItemsSource = null;
                people_ListView.ItemsSource = peopleList;
            }
        }

        private void search_Button_clicked(object sender, RoutedEventArgs e)
        {
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
