using System;

using System.Collections.Generic;
using System.Text;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;

namespace PDAUpdate.Utils
{
    public class ZipHelper
    {
        /// <summary>
        /// 压缩文件夹
        /// </summary>
        /// <param name="dirPath">压缩文件夹的路径</param>
        /// <param name="fileName">生成的zip文件路径</param>
        /// <param name="level">压缩级别 0 - 9 0是存储级别 9是最大压缩</param>
        public static void CompressDirectory(string dirPath, string fileName, int level)
        {
            byte[] buffer = new byte[4096];
            using (ZipOutputStream s = new ZipOutputStream(File.Create(fileName)))
            {
                s.SetLevel(level);
                CompressDirectory(dirPath, s, buffer);
                s.Finish();
                s.Close();
            }
        }

        /// <summary>
        /// 压缩文件夹
        /// </summary>
        /// <param name="root">压缩文件夹路径</param>
        /// <param name="path">压缩文件夹内当前要压缩的文件夹路径</param>
        /// <param name="s"></param>
        /// <param name="buffer">读取文件的缓冲区大小</param>
        private static void CompressDirectory(string path, ZipOutputStream s, byte[] buffer)
        {
            string[] fileNames = Directory.GetFiles(path);
            string[] dirNames = Directory.GetDirectories(path);

            int sourceBytes;
            foreach (string file in fileNames)
            {
                ZipEntry entry = new ZipEntry(file);
                entry.DateTime = DateTime.Now;
                s.PutNextEntry(entry);
                using (FileStream fs = File.OpenRead(file))
                {
                    do
                    {
                        sourceBytes = fs.Read(buffer, 0, buffer.Length);
                        s.Write(buffer, 0, sourceBytes);
                    } while (sourceBytes > 0);
                }
            }

            foreach (string dirName in dirNames)
            {
                ZipEntry entry = new ZipEntry(dirName);
                s.PutNextEntry(entry);
                CompressDirectory(dirName, s, buffer);
            }
        }

        /// <summary>
        /// 解压缩zip文件
        /// </summary>
        /// <param name="zipFilePath">解压的zip文件路径</param>
        /// <param name="extractPath">解压到的文件夹路径</param>
        public static void Extract(string zipFilePath, string extractPath)
        {
            byte[] data = new byte[4096];
            int size;
            using (ZipInputStream s = new ZipInputStream(File.OpenRead(zipFilePath)))
            {
                ZipEntry entry;
                while ((entry = s.GetNextEntry()) != null)
                {
                    string name = entry.Name;
                    string directoryName = Path.GetDirectoryName(name);
                    string fileName = Path.GetFileName(name);

                    //先创建目录
                    if (directoryName.Length > 0)
                    {
                        Directory.CreateDirectory(Path.Combine(extractPath, directoryName));
                    }

                    if (string.IsNullOrEmpty(fileName)) continue;

                    using (FileStream streamWriter = File.Create(Path.Combine(extractPath, name)))
                    {
                        while (true)
                        {
                            size = s.Read(data, 0, data.Length);
                            if (size <= 0) break;
                            streamWriter.Write(data, 0, size);
                        }
                    }
                }
            }
        }
    }

}
