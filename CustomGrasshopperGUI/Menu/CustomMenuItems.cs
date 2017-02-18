using Grasshopper.Kernel;
using System;
using System.Windows.Forms;

namespace CustomGrasshopperGUI.Menu
{
    public class CustomMenuItems : GH_Component
    {

        public CustomMenuItems()
          : base("CustomMenuItems", "CustomMenuItems",
              "Example of Custom Menu Items",
              "Extra", "Custom GUI Tutorial")
        {
        }

        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            // Example input
            pManager.AddIntegerParameter("Input", "I", "Example of an Input", GH_ParamAccess.item);
        }

        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            // Example output
            pManager.AddIntegerParameter("Output", "O", "Example of an Output", GH_ParamAccess.item);
        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
        }

        public override void AppendAdditionalMenuItems(ToolStripDropDown menu)
        {
            menu.Items.Add("My first Custom Menu Item", null, menuFirstItemClicked);
            menu.Items.Add("My second Custom Menu Item", null, menuSecondItemClicked);
            menu.Items.Add("My third Custom Menu Item", null, menuThirdItemClicked);
            Menu_AppendSeparator(menu);
            menu.Items.Add("My fourth Custom Menu Item", null, menuFourthItemClicked);
            menu.Items.Add("My fifth Custom Menu Item", null, menuFifthItemClicked);
            Menu_AppendSeparator(menu);
            menu.Items.Add("My last Custom Menu Item", null, menuLastItemClicked);

            base.AppendAdditionalMenuItems(menu);
        }

        public void menuFirstItemClicked(object sender, EventArgs e)
        {
            // Do something
        }

        public void menuSecondItemClicked(object sender, EventArgs e)
        {
            // Do something
        }

        public void menuThirdItemClicked(object sender, EventArgs e)
        {
            // Do something
        }

        public void menuFourthItemClicked(object sender, EventArgs e)
        {
            // Do something
        }

        public void menuFifthItemClicked(object sender, EventArgs e)
        {
            // Do something
        }

        public void menuLastItemClicked(object sender, EventArgs e)
        {
            // Do something
        }

        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                return null;
            }
        }

        public override Guid ComponentGuid
        {
            get { return new Guid("{a1097fcc-833d-491b-8c1c-58b911b3d4d5}"); }
        }
    }
}
