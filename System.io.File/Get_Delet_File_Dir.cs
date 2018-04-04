using System.IO;
class FileCode {

    /// <summary>
    /// 获取指定目录中子目录名称（包括路径）不包括文件的获取
    /// find all the sub Dir path (include dirname) in the target Dir
    /// </summary> 
    public void GetAllSubDir(String hubDirPath) {
        String[] folders = Directory.GetDirectories(path); //***
        foreach (String str in folders) {
            //TBD
        }
    }
    /// <summary>
    /// 获取指定目录中文件名称（包括路径）不包括子目录的获取
    /// find all the sub file path (include filename) in the target Dir
    /// </summary> 
    public void GetAllSubFile(String hubDirPath) {
        String[] files =  Directory.GetFiles(path); //***
        foreach(String str in files) {

        }
    }

    /// <summary>
    /// 获取指定目录中子全部子目录及子文件
    /// 判断获取的Item是文件还是目录
    /// 删除指定文件及目录
    /// </summary>
    public void GetAllSubItem(String hubDirPath) {
        DirectoryInfo dir = new DirectoryInfo(hubDirPath); //***
        FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();
        foreach (FileSystemInfo i in fileinfo) {
            //也可以不进行判断直接 i.Delete();
            if(i is DirectoryInfo) {
                DirectoryInfo subdir = new DirectoryInfo(i.FullName); //删除该指定目录
                subdir.Delete(true);
            }else {
                File.Delete(i.FullName); //删除文件,参数为文件路径String，删除时要注意写try catch
            }
        }


    }

    /// <summary>
    /// 判断文件或者文件夹是否存在
    /// </summary>
    public void findIfItemExist(String ItemName) {
        if (File.Exists(fileName)) { //判断文件是否存在
            //TBD
        }
        if(Directory.Exists(fileName);) { //判断文件夹是否存在
            //TBD
        }
    }

    /// <summary>
    /// 获取指定文件或文件夹信息
    /// </summary>
    FileInfo fi = new FileInfo(FileName);
    DirectoryInfo dir = new DirectoryInfo(dirD);
    //i属性获取文件及文件夹信息 fi or dir
    fi.Exists; //获取指定文件是否存在;
    fi.Name; fi.Extensioin; //获取文件的名称和扩展名
    fi.FullName; //获取文件的全限定名称（完整路径）
    fi.Directory; //获取文件所在目录，返回类型为DirectoryInfo
    fi.DirectoryName; //获取文件所在目录的路径（完整路径）
    fi.Length; //获取文件的大小（字节数）
    fi.IsReadOnly; //获取文件是否只读
    fi.Attributes; //获取或设置指定文件的属性，返回类型为FileAttributes枚举，可以是多个值的组合
    fi.CreationTime; fi.LastAccessTime; fi.LastWriteTime; //分别用于获取文件的创建时间、访问时间、修改时间
    

   

}