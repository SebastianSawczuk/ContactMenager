using ClassLibrary;
using System.Drawing.Text;
using System.Xml.Serialization;
using System.Reflection;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        List<Contact> _contacts = new List<Contact>();
        public Form1()
        {
            InitializeComponent();

            contactBindingSource.DataSource = _contacts;
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();

            using (Stream stream = File.Create(saveFileDialog.FileName))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Contact>));
                serializer.Serialize(stream, _contacts);
            }
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            using (Stream stream = File.OpenRead(openFileDialog.FileName))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Contact>));
                List<Contact>? loadedContacts = serializer.Deserialize(stream) as List<Contact>;
                if (loadedContacts != null)
                {
                    _contacts.Clear();
                    _contacts.AddRange(loadedContacts);
                    contactBindingSource.ResetBindings(false);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("to dzia³a");
            DirectoryInfo directoryInfo = new DirectoryInfo("Plugins");
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                Assembly assembly = Assembly.LoadFrom(file.FullName);

                Type[] types = assembly.GetTypes()
                    .Where(t => t.IsClass && t.GetInterface(nameof(IPluginable)) != null).ToArray();

                foreach (Type type in types)
                {
                    Object? obj = Activator.CreateInstance(type);
                    if (obj != null)
                    {
                        IPluginable plugin = (IPluginable)obj;

                        // zapisywanie do pliku z wtyczki
                        ToolStripMenuItem saveItem = new ToolStripMenuItem(plugin.Format);
                        saveToToolStripMenuItem.DropDownItems.Add(saveItem);
                        saveItem.Click += (obj, ea) =>
                        {
                            SaveFileDialog dialog = new SaveFileDialog();
                            dialog.ShowDialog();

                            plugin.Save(_contacts, dialog.FileName); 
                        };

                        ToolStripMenuItem loadItem = new ToolStripMenuItem(plugin.Format);
                        loadToolStripMenuItem.DropDownItems.Add(loadItem);
                        loadItem.Click += (obj, ea) =>
                        {
                            OpenFileDialog dialog = new OpenFileDialog();
                            dialog.ShowDialog();

                            List<Contact> loadedContacts = plugin.Load(dialog.FileName);

                            if (loadedContacts != null)
                            {
                                _contacts.Clear();
                                _contacts.AddRange(loadedContacts);
                                contactBindingSource.ResetBindings(false);
                            }
                        };

                        ToolStripMenuItem infoItem = new ToolStripMenuItem(plugin.Format);
                        helpToolStripMenuItem.DropDownItems.Add(infoItem);
                        infoItem.Click += (obj, ea) =>
                        {
                            Console.WriteLine("to dzia³a");
                            object? attrObj = type.GetCustomAttribute(typeof(InfoAttribute));
                            if(attrObj != null)
                            {
                                InfoAttribute attr = (InfoAttribute)attrObj;
                                MessageBox.Show(attr.Author.ToString());
                            }
                        };
                    }
                }

            }
        }
    }
}