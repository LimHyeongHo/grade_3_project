using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_test_study
{
    internal class class_4
    {
        /// 정적 클래스 file.ReadAllText(), writeAllText() 등등 존재함. 
        /// 간단하긴 하나 한번만 추가함. 
        /// 

        /// filestream 위주로 사용
        /// 주요 생성자 : FileStream( 경로, 파일모드, 접근모드 )
        /// 바이트 기반 처리, 대용량 파일 처리, 저수준 처리, 문자열은 무조건 Encoding 필요

        static void Class_4()
        {
            string path = @"C:\Users\super\OneDrive\바탕 화면\폴더정리\1. Project\3학년\03. C#\grade_3_project\mid_test\mid_test_study/filestreamTest.txt";
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);

            Console.Write("입력 : ");
            string text = Console.ReadLine();
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            fs.Write(bytes, 0 , bytes.Length);
            fs.Close();

        }

    }

}
