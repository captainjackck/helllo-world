using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeatCal.Model;
using HeatCal.Logic;
using HeatCal.View.fuel;

namespace HeatCal
{
    //输出列表中元素结构体
    [Serializable]
    public struct listItem
    {
        public string name;//被计算值的名称
        public string sign;//被计算值的物理符号
        public string danwei;//单位
        public string gongshi;//公式或依据（表、线算图、输入、预先给定）
        public string result;//计算结果

        public listItem(string nameval, string signval, string danweival, string gongshival, string resultval)
        {
            name = nameval;
            sign = signval;
            danwei = danweival;
            gongshi = gongshival;
            result = resultval;
        }
    }

    [Serializable]
    public class Boiler
    {
        /// <summary>
        /// 部件名称对应的实体
        /// </summary>
        private SortedList<string, ComponentEntity> bjlist = new SortedList<string, ComponentEntity>();
        /// <summary>
        /// 烟气侧矩阵
        /// </summary>
        private List<List<double>> qubelist1 = new List<List<double>>();
        /// <summary>
        /// 水侧矩阵
        /// </summary>
        private List<List<double>> qubelist2 = new List<List<double>>();
        /// <summary>
        /// 空气侧矩阵
        /// </summary>
        private List<List<double>> qubelist3 = new List<List<double>>();
        /// <summary>
        /// 灰侧矩阵
        /// </summary>
        private List<List<double>> qubelist5 = new List<List<double>>();
        /// <summary>
        /// 构建流程中datagriview4中有几条错误信息
        /// </summary>
        private int m_checkflow_number = 0;

        public int Checkflow_number
        {
            get { return m_checkflow_number; }
            set { m_checkflow_number = value; }
        }

       
        /// <summary>
        /// 存放listbox1的项
        /// </summary>
        private List<string> m_list1 = new List<string>();
        /// <summary>
        /// 存放listbox2的项
        /// </summary>
        private List<string> m_list2 = new List<string>();


        /// <summary>
        /// 烟气侧矩阵
        /// </summary>
        public List<List<double>> Qubelist1
        {
            get { return this.qubelist1; }
            set { this.qubelist1 = value; }
        }

        /// <summary>
        /// 水侧矩阵
        /// </summary>
        public List<List<double>> Qubelist2
        {
            get { return this.qubelist2; }
            set { this.qubelist2 = value; }
        }        
        /// <summary>
        /// 灰矩阵
        /// </summary>
        public List<List<double>> Qubelist5        
        {
            get { return this.qubelist5; }
            set { this.qubelist5 = value; }
        }
        public List<string> List1
        {
            get { return m_list1; }
            set { m_list1 = value; }
        }

        public List<string> List2
        {
            get { return this.m_list2; }
            set { this.m_list2 = value; }
        }
        /// <summary>
        /// 空气侧矩阵
        /// </summary>
        public List<List<double>> Qubelist3
        {
            get { return this.qubelist3; }
            set { this.qubelist3 = value; }
        }

        public SortedList<string, ComponentEntity> Bjlist
        {
            get { return this.bjlist; }
            set { this.bjlist = value; }
        }

       
              
       
        
       
      
        /// <summary>
        /// 热平衡界面对应的实例
        /// </summary>
        private RePingHeng m_Repingheng = new RePingHeng();//热平衡

        public RePingHeng Repingheng
        {
            get { return this.m_Repingheng; }
            set { this.m_Repingheng = value; }
        }
        /// <summary>
        /// 燃料界面对应的实例
        /// </summary>
        private Fuel_param m_fuelparam = new Fuel_param();//燃料

        public Fuel_param Fuelparam
        {
            get { return m_fuelparam; }
            set { m_fuelparam = value; }
        }


       private Water m_bWater;//水工质

        internal Water BWater
        {
            get { return this.m_bWater = new Water() ; }
            set { this.m_bWater = value; }
        }
        private Air m_bAir;//空气工质

        internal Air BAir
        {
            get { return this.m_bAir = new Air(); }
            set { this.m_bAir = value; }
        }
        private Gas m_bGas;//烟气工质

        internal Gas BGas
        {
            get 
            {
                m_bGas = new Gas();
                return m_bGas;
            }
            set { this.m_bGas = value; }
        }
        private Ash m_bAsh;
        /// <summary>
        /// 灰
        /// </summary>
        internal Ash BAsh
        {
            get { return this.m_bAsh=new Ash(); }            
        }

        private BoilerInfo boilerInfo = new BoilerInfo();

        public BoilerInfo Boilerinfo
        {
            get { return boilerInfo; }
            set { boilerInfo = value; }
        }

        //private ComponentEntity m_currentEntity;//当前被编辑的部件对象

        //public ComponentEntity CurrentEntity
        //{
        //    get { return this.m_currentEntity; }
        //    set { this.m_currentEntity = value; }
        //}

    }
}
