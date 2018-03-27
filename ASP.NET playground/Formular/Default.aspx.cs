using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Xml;

public partial class _Default : System.Web.UI.Page
{
    public interface IFace
    {
        String getName(String name);
        int a(int b);
    }

    class H : IFace {

        public String getName(String name)
        {
            return name;
        }

        public int a(int b)
        {
            return b;
        }
    }

    // enum Days
    enum Days { Sunday, Monday, Tuesday, Wedensday, Thuesday, Friday, Saturday };

    // interface IFace from H class
    IFace f = new H();
    
    // grid view datatable
    DataTable dt1 = new DataTable();

    // int array arrnumber
    int[] arrnumber = new int[21];

    // list nlist
    List<int> nlist = new List<int>();

    // list plist
    List<Person> plist = new List<Person>();

    // xml document
    XmlDocument document = new XmlDocument();

    //public void loadJson()
    //{
    //    using(StreamReader r = new StreamReader(Server.MapPath("~/json.json")))
    //    {
    //        string json = r.ReadToEnd();
    //        //dynamic dynJson = JsonConvert.DeserializeObject(json);
    //        List<Employee> emp = JsonConvert.DeserializeObject<List<Employee>>(json);

    //        foreach (var rootObject in emp)
    //        {
    //            Literal_json.Text = rootObject.Name;
    //        }
    //    }
    //}

    private double calcForFun(char sign, double number1, double number2)
    {
        double res = 0.0;
        switch (sign)
        {
            case '+':
                res = number1 + number2;
                break;
            case '-':
                res = number1 - number2;
                break;
            case '*':
                res = number1 * number2;
                break;
            case '/':
                res = number1 / number2;
                break;
            default:
                break;
        }
        return res;
    }

    private void changeLetterForFun(char letter){
        switch (letter)
        {
            case 'A':
                Literal_letter.Text = "Your grade was: " + letter + " ...Excellent!";
                break;
            case 'B':
            case 'C':
                Literal_letter.Text = "Your grade was: " + letter + " ...Well done";
                break;
            case 'D':
                Literal_letter.Text = "Your grade was: " + letter + " ...You passed";
                break;
            case 'F':
                Literal_letter.Text = "Your grade was: " + letter + " ...Better try again";
                break;
            default:
                Literal_letter.Text = "Your grade was: " + letter + " ...Invalid grade";
                break;
        }
    }

    private void makeNumber()
    {
        for (int i = 0; i < arrnumber.Length; i++)
        {
            nlist.Add(i);
        }
    }

    private void gridViewData() 
    {
        dt1.Columns.Add("Name", typeof(string));
        dt1.Columns.Add("Email", typeof(string));
        dt1.Columns.Add("Food", typeof(string));
        dt1.Columns.Add("Phone", typeof(string));
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        // let's make some numbers in nlist
        makeNumber();
        
        // load json
        //loadJson();

        // interface
        Literal_interface.Text = "Interface: " + f.getName("abe") + " id: " + f.a(1);

        // switch changeLetterForFun
        changeLetterForFun('A');

        // enum
        Days day = Days.Tuesday;
        Literal_day.Text = "Enum day: " + day.ToString();

        // calcForFun
        Literal_calc.Text = "Number with switchcase: " + Convert.ToString(calcForFun('*', 7.0, 3.0));

        // let's make some persons in plist
        plist.Add(new Person("Casper", 29));
        plist.Add(new Person("Jeff", 26));
        plist.Add(new Person("Shakalali", 24));
        plist.Add(new Person("Stephan", 30));
        plist.Add(new Person("AJ", 29));

        if (!IsPostBack)
        {
            gridViewData();
            GridView_show.DataSource = dt1;
            GridView_show.DataBind();
            Session["dt1"] = dt1;

            // list nlist reversed
            nlist.Reverse();

            // loop list nlist 
            foreach (var item in nlist)
            {
                Literal_loop.Text = Literal_loop.Text + "N: " + item + " <br />";
            }

            // loop list plist 
            foreach (var item in plist)
            {
                Literal_person.Text = Literal_person.Text + item.Describe() + " <br />";
            }

            // xml
            document.Load(Server.MapPath("~/XMLFile.xml")); // Load XML File document.LoadXml(xmlString)
            XmlNodeList nodes = document.SelectNodes("/Human/body");
            foreach (XmlNode item in nodes)
            {
                Literal_xml.Text = Literal_xml.Text + "XML: " + item.InnerXml + "<br />";
            }
            

        }
    }

    protected void Button_send_Click(object sender, EventArgs e)
    {
        if (Session["dt1"] != null) dt1 = (DataTable)Session["dt1"];
        DataRow dr = dt1.NewRow();
        dr["name"] = TextBox_name.Text;
        dr["email"] = TextBox_email.Text;
        dr["food"] = TextBox_food.Text;
        dr["phone"] = DropDownList_phone.SelectedValue;
        dt1.Rows.Add(dr);
        GridView_show.DataSource = dt1;
        GridView_show.DataBind();
    }
}