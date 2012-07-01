using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Threading;
using System.Diagnostics;

namespace WorkingClassSample
{
    class Program
    {

        static void Main(string[] args)
        {
            string msg = "aaaa";

            string msg2 = "a{0}a";
            Console.WriteLine(msg+string.Format(msg2, "TERST"));
            Console.WriteLine("end");

        }
    //    static void Main(string[] args)
    //    {
    //        WorkingClass wc = new WorkingClass("Test Thread Parameter", 10,
    //                 new WorkingClassCallBack(ResultCallback));

    //        Thread thd = new Thread(new ThreadStart(wc.ThreadProc));
                
    //        Console.WriteLine("쓰레드 실행!");

    //        thd.Start();

    //        thd.Join();

    //        Console.WriteLine("쓰레드 종료, 메인 스레드 종료.");
    //    }

    //    //반환값을 출력할 콜백 메서드
    //    public static void ResultCallback(string str)
    //    {
    //        Console.WriteLine(str);
    //    }
    }
        
    //콜백 메서드의 대리자
    public delegate void WorkingClassCallBack(string str);

    //스레드용 클래스
    class WorkingClass
    {
        private string name;  //스레드 프로시저에서 사용될 파라미터들
        private int value;
        private WorkingClassCallBack callback;  //결과값을 반환할 콜백 대리자

        public WorkingClass(string name, int value, WorkingClassCallBack callback)
        {
            this.name = name;   //생성자에서 초기화
            this.value = value;
            this.callback = callback;
        }

        //스레드 프로시저
        public void ThreadProc()
        {
            Console.WriteLine("메서드 실행 => name:" + name + ", value:" + value);
            if (callback != null) //콜백 대리자 확인후 실행.
            {
                callback("반환값은 콜백 메서드로 반환:" + value);
            }
        }
    }
}
