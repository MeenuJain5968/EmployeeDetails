using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAPIDemo
{
    public partial class CallAPI : Form
    {
        public static string totalPages = "";
        private static readonly string baseURL = "https://gorest.co.in/public-api/";
        public CallAPI()
        {
            InitializeComponent();            
        }
        public static async Task<string> GetTotalPages()
        {

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "users"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();

                        var deserializedata = (JObject)JsonConvert.DeserializeObject(data);
                        string total_no_of_pages = deserializedata["meta"]["pagination"]["pages"].Value<string>();
                        if (total_no_of_pages != "")
                            return total_no_of_pages;
                    }
                }

            }
            return "0";

        }
        private  async void GetEmployeeDetails_Click(object sender, EventArgs e)
        {           
            if(totalPages == "")
                totalPages = await GetTotalPages();
            string pageNumber = txtpage.Text;
            if (pageNumber == "")
                pageNumber = "1";
          var response = await RestHelper.GetAll(pageNumber, totalPages);
            txtResponse.Text = RestHelper.JsonFormat(response);
        }

        private async void GetByID_Click(object sender, EventArgs e)
        {
            var response = "";
            if (txtid.Text != "")
            {
                response =  await RestHelper.Get(txtid.Text);
                txtResponse.Text = RestHelper.JsonFormat(response);
                txtid.Text = "";
            }
            else
                MessageBox.Show("Please enter Employee ID to get details.");

            
        }

        private async void Insert_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.InsertDetails(txtname.Text,txtgender.Text,txtemail.Text,txtstatus.Text);
            txtResponse.Text = RestHelper.JsonFormat(response);
            txtname.Text = "";
            txtgender.Text = "";
            txtemail.Text = "";
            txtstatus.Text = "";
        }

        private async void txtdelete_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.Delete(txtid.Text);
            txtResponse.Text = response;
        }

    }
}
