using Grasshopper.Kernel;
using System;
using System.Windows.Forms;

namespace CustomGrasshopperGUI.Menu
{
    public class CustomMenu : GH_Component
    {

        public CustomMenu()
          : base("CustomMenu", "CustomMenu",
              "Example of Custom Menu",
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

        public override bool AppendMenuItems(ToolStripDropDown menu)
        {
            menu.Items.Add("My first Custom Menu Item", null, menuItemClicked);
            menu.Items.Add("My second Custom Menu Item", null, menuItemClicked);
            menu.Items.Add("My third Custom Menu Item", null, menuItemClicked);
            Menu_AppendSeparator(menu);
            menu.Items.Add("My fourth Custom Menu Item", null, menuItemClicked);
            menu.Items.Add("My fifth Custom Menu Item", null, menuItemClicked);
            Menu_AppendSeparator(menu);
            menu.Items.Add("My last Custom Menu Item", null, menuItemClicked);

            return true;
        }

        public void menuItemClicked(object sender, EventArgs e)
        {
            MessageBox.Show("yes");
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
            get { return new Guid("{628c91ba-204c-46d6-a3d1-a99403c3aac6}"); }
        }
    }
}
