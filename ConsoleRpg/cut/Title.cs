﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpg.cut
{
    public class Title : Basecut
    {
        public Title()
        {
            //타이틀 컷신의 초기화
        }
        public override void Render()
        {
            //타이틀 컷신의 렌더링
            Console.WriteLine("/*********************************************************************************************\r\n/**/////////////////////////////////////////////////////////////////////////////////////////** \r\n/** \t\t\t\t\t\t\t\t   \t\t\t   /**\r\n/**\t ****     ****     **     ******** ********   *******   *******    ********\t   /**\r\n/**\t/**/**   **/**    ****   //////** /**/////   /**////** /**////**  **//////**\t   /**\r\n/**\t/**//** ** /**   **//**       **  /**        /**   /** /**   /** **      // \t   /**\r\n/**\t/** //***  /**  **  //**     **   /*******   /*******  /******* /**\t           /**\r\n/**\t/**  //*   /** **********   **    /**////    /**///**  /**////  /**    *****\t   /**\r\n/**\t/**   /    /**/**//////**  **     /**        /**  //** /**      //**  ////**\t   /**\r\n/**\t/**        /**/**     /** ********/********  /**   //**/**       //******** \t   /**\r\n/**\t//         // //      // //////// ////////   //     // //         ////////\t   /**\r\n/**\t\t\t\t\t\t\t\t  \t\t\t   /**\r\n/*********************************************************************************************\r\n/////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine();
            Console.Write("\t\t\t\tPress any key to start the game...");
           

        }
        public override void Input()
        { Console.ReadKey(true); //키 입력을 대기한다.
            //타이틀 컷신의 입력처리
        }
        public override void Update()
        {
            //타이틀 컷신의 업데이트
        }
        public override void Result()
        {
            //타이틀 컷신의 결과처리
        }
    }
    


    }
