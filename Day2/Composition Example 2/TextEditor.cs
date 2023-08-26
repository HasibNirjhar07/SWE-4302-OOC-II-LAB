using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_Example_2
{
    public class TextEditor
    {
        private Buffer buffer;
        private File file;

        public TextEditor(File file)
        {
            this.file = file;
            this.buffer = new Buffer("");
        }

        public void open()
        {
            Console.WriteLine("Opening file:" + file.getFileName());

            buffer = new Buffer("Content of" + file.getFileName());
        }
        public void edit(string Newcontent)
        {
            Console.WriteLine("Editing Content.....");
            buffer = new Buffer(Newcontent);
        }
        public void save()
        {
           Console.WriteLine("Saving changes to file:" + file.getFileName());
        }

        public void close()
        {
            Console.WriteLine("Closing File: " + file.getFileName());
            buffer = null;
        }

        public string getContent()
        {
            return buffer.getContent();
        }
    }
}
