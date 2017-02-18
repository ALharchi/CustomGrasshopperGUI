using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace CustomGrasshopperGUI
{
    public class CustomGrasshopperGUIInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "Custom Grasshopper GUI Tutorial";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                return null;
            }
        }
        public override string Description
        {
            get
            {
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("956e50c2-a71c-4111-b016-66d0a1be5cfd");
            }
        }

        public override string AuthorName
        {
            get
            {
                return "Ayoub Lharchi";
            }
        }
        public override string AuthorContact
        {
            get
            {
                return "http://www.lharchi.com";
            }
        }
    }
}
