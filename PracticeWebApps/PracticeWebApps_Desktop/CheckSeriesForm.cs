using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWebApps_Desktop
{
    public partial class CheckSeriesForm : Form
    {
        ProductManager productManager;
        public CheckSeriesForm()
        {
            InitializeComponent();
            productManager = new ProductManager(new ProductDAL());
            foreach (var item in productManager.LoadObjects())
            {
                if (item is Movie)
                {
                    lbSeries.Items.Add(item);
                }
            }
        }
    }
}
