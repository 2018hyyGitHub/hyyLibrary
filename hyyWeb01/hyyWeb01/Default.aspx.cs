using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hyyWeb01
{
    public partial class _Default : Page
    {

        //普通属性
        private string _testStr1 = "默认文本";
        public string TestStr1
        {
            get { return _testStr1; }
            set { _testStr1 = value; }
        }

        //视图属性
        public string TestStr2
        {
            get { return ViewState["TestStr2"] == null ? "默认文本" : ViewState["TestStr2"].ToString(); }
            set { ViewState["TestStr2"] = value; }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //ViewState["test"] = "test";                
                //TestStr1 = "TestStr1";

                System.Web.UI.StateBag _StateBag = new StateBag();
                _StateBag["Test0"] = 0;
                var test = _StateBag["Test0"].ToString();
                bool isdirty = _StateBag.IsItemDirty("Test0");
                _StateBag["Test0"] = 0;
                isdirty = _StateBag.IsItemDirty("Test0");
                this.TrackViewState();
                //StateBag.TrackViewState();
                _StateBag["Test0"] = 1;
                isdirty = _StateBag.IsItemDirty("Test0");
            }
            else
            {
                //string test = ViewState["test"] == null ? "" : ViewState["test"].ToString();
                //string test = TestStr1;
                System.Web.UI.StateBag _StateBag = new StateBag();
                _StateBag["Test0"] = 2;
                bool isdirty = _StateBag.IsItemDirty("Test0");
            }
        }
    }
}