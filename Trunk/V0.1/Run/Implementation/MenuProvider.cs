using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using Medical.Common;
using Medical.Forms.EventArgs;
using Medical.Forms.Implements;
using Medical.Forms.Interfaces;
using Medical.Forms.TreeMenu;

namespace Run.Implementation
{
    public class MenuProvider : IMenuManager
    {
        private readonly string _iconPath = Application.StartupPath + "\\Icons";
        public event EventHandler<MenuItemClickedEventArgs> MenuItemClicked;
        private readonly List<TopMenuItem> _toolBarItem;
        private string _configFile;

        private TopMenuItem _rootItem;

        private readonly TreeMenu _treeMenu;
        private ImageList _images;

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuProvider"/> class.
        /// </summary>
        public MenuProvider()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuProvider"/> class.
        /// </summary>
        /// <param name="configFile">The config file.</param>
        public MenuProvider(string configFile) : this()
        {
            _treeMenu = Xml.Load<TreeMenu>(configFile);
            _images = new ImageList();
         
            var images = (TreeMenuImages)Xml.Load<TreeMenuImages>("TreeMenuImage.xml");
            if (images == null) return;
            for (int i = 0; i < images.Files.Count; i++)
            {
                // _images.
                images.Files.AddRange(images.Files.);
            }
        }

        /// <summary>
        /// Bindings the menu item. 
        /// </summary>
        /// <param name="cntrl">The CNTRL.</param>
        /// <param name="item">The item.</param>
        public void BindingMenuItem(Control cntrl, TopMenuItem item)
        {
        }

        /// <summary>
        /// Creates the menu item.
        /// </summary>
        public void CreateMenuItem(params Control[] menuCntrl)
        {
            if (menuCntrl == null) return;
            if (menuCntrl.Length == 0) return;
            var trip = menuCntrl[0] as TreeView;
            LoadMenuItem(trip);
        }


        /// <summary>
        /// Creates the tool bar. 
        /// Note: Call after create menu strip to  fully loading of item
        /// </summary>
        /// <param name="toolbar">The toolbar.</param>
        public void CreateToolBar(ToolStrip toolbar)
        {
        }

        /// <summary>
        /// Loads the menu item.
        /// </summary>
        /// <param name="tree"> </param>
        private void LoadMenuItem(TreeView tree)
        {
            tree.NodeMouseClick += TreeNodeMouseClick;

            foreach (var item in this._treeMenu.MenuItems)
            {
                var childNode = new TreeNode(item.Title) { Name = item.Key, ImageIndex = item.ImageIndex, ToolTipText = item.Description };
                GetNote(childNode, item);
                tree.Nodes.Add(childNode);
            }
        }

        private void TreeNodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var node = e.Node;
            var item = new MenuItemClickedEventArgs { Key = node.Name, InvokeKey = String.Empty };
            this.MenuItemClicked(sender, item);
        }

        private void GetNote(TreeNode node, TreeMenuItem item)
        {
            if (item == null) return;
            if (item.Childs.Count == 0) return;
            foreach (var child in item.Childs)
            {
                var childNode = new TreeNode(child.Title) { Name = child.Key, ImageIndex = item.ImageIndex, ToolTipText = item.Description };
                GetNote(childNode, child);
                node.Nodes.Add(childNode);
            }
        }

        /// <summary>
        /// Gets the menu item by key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public TopMenuItem GetMenuItemByKey(string key)
        {
            return null;
        }

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>The count.</value>
        public int Count
        {
            get { return 0; }
        }

        /// <summary>
        /// Sets the config file.
        /// </summary>
        /// <value>The config file.</value>
        public string ConfigFile
        {
            set
            {
                this._configFile = value;
            }
        }
    }
}
