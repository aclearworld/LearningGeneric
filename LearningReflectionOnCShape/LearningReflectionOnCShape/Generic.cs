using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LearningReflectionOnCShape
{
    public class Generic<T>
        where T:class
    {
        private T target;
        private Type targetType;
        private StreamWriter fs;

        public Generic(T target ,string path)
        {
            this.target = target;
            this.targetType = this.target.GetType();
            this.fs = new StreamWriter(path,false);
        }

        /// <summary>
        /// Save
        /// </summary>
        public void Save()
        {
            this.writeFiled();
            this.writeProPerty();

            this.fs.Close();
        }

        /// <summary>
        /// フィールド書き込み
        /// </summary>
        private void writeFiled()
        {
            FieldInfo[] filedInfos = this.targetType.GetFields();
            foreach (var filedInfo in filedInfos.Where(info => { return info.IsPublic; })) {
                this.fs.WriteLine($"フィールド名 :{filedInfo.Name}" +
                    $" | 値 :{filedInfo.GetValue(this.target).ToString()}");
            }
        }
        
        private void writeProPerty()
        {
            PropertyInfo[] propertyInfos = this.targetType.GetProperties();
            foreach (var propertyInfo in propertyInfos)
            {
                this.fs.WriteLine($"プロパティ名 :{propertyInfo.Name}" +
                    $" | 値 :{propertyInfo.GetValue(this.target).ToString()}");
            }
        }
    }
}
