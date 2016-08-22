using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.Core.WireProtocol.Messages;

namespace NamaCard
{
  public partial class NamacardMng : Form
  {
    public NamacardMng()
    {
      InitializeComponent();

      GetNamecardList();
    }

    private void ClearForm()
    {
      txtName.Text = txtPhone.Text = txtCompany.Text = txtMail.Text = txtAddr.Text = string.Empty;
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      GetNamecardList();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var connectionSgtring = "mongodb://localhost:27017";
      var client = new MongoClient(connectionSgtring);

      var db = client.GetDatabase("week2");
      var col = db.GetCollection<BsonDocument>("namecards");

      var doc = new BsonDocument
      {
        {"Name", txtName.Text},
        {"Adress", txtAddr.Text},
        {"CompanyName", txtCompany.Text},
        {"Email", txtMail.Text},
        {"PhoneNo", txtPhone.Text}
      };
      col.InsertOne(doc);

      GetNamecardList();

      ClearForm();
    }

    private void GetNamecardList()
    {
      var connectionSgtring = "mongodb://localhost:27017";
      var client = new MongoClient(connectionSgtring);

      var db = client.GetDatabase("week2");
      var col = db.GetCollection<Namecard>("namecards");

      var filter = new BsonDocument();

      if (string.IsNullOrEmpty(txtSearchText.Text) == false)
      {
        filter.Add("Name", new BsonRegularExpression(txtSearchText.Text));
   
      }

      var cur = col.FindSync(filter).ToList();

      dataGridView1.DataSource = ConvertToDataTable(cur);
    }

    public DataTable ConvertToDataTable<T>(IList<T> data)
    {
      PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
      DataTable table = new DataTable();

      foreach (PropertyDescriptor prop in properties)
        table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

      foreach (T item in data)
      {
        DataRow row = table.NewRow();
        foreach (PropertyDescriptor prop in properties)
          row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
        table.Rows.Add(row);
      }

      return table;
    }

    public class Namecard
    {

      [BsonId]
      public ObjectId _id { get; set; }
      [BsonElement]
      public string Name { get; set; }
      [BsonElement]
      public string Adress { get; set; }
      [BsonElement]
      public string CompanyName { get; set; }
      [BsonElement]
      public string Email { get; set; }
      [BsonElement]
      public string PhoneNo { get; set; }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      ClearForm();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      var rows = dataGridView1.SelectedRows;

      foreach (DataGridViewRow row in rows)
      {
        //row["id"];
        //row.Cells["id"];


        var connectionSgtring = "mongodb://localhost:27017";
        var client = new MongoClient(connectionSgtring);

        var db = client.GetDatabase("week2");
        var col = db.GetCollection<Namecard>("namecards");

        BsonDocument filter = new BsonDocument
        {
          {"_id",new ObjectId(row.Cells["id"].Value.ToString())}
        };
        col.DeleteOne(filter);

        GetNamecardList();
      }
    }
  }
}
