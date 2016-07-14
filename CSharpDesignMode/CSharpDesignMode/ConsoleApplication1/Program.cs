using AbstractFactoryMode;
using AdapterMode;
using BuilderMode;
using CompositeMode;
using FactoryMode;
using PrototypeMode;
using StatePatternModel;
using StatePatternModel.Card;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 工厂方法

            //Factory eggFactory = new EggFactory();
            //Factory potatoFactory = new PotatoFactory();

            //Food egg = eggFactory.CreateFoodFactory();
            //Food potato = potatoFactory.CreateFoodFactory();

            //egg.Print();
            //potato.Print();

            //Console.Read();

            #endregion

            #region 抽象工厂

            //AbstractFactory shangHaiFactory = new ShangHaiFactory();
            //shangHaiFactory.CreateYaBo().Print();


            //Console.Read();

            #endregion

            #region 建造者模式

            ////指挥者
            //Director director = new Director();

            ////建造者
            //Builder1 builder1 = new Builder1();
            //director.Construct(builder1);

            //Computer computer1 = builder1.GetComputer();

            //computer1.Show();

            //Console.ReadKey();

            #endregion

            #region 原型模式

            ////原型
            //MonkeyKingPrototype monkeyKing = new Cloned("MonkeyKing");

            ////克隆1
            //MonkeyKingPrototype clone1 = monkeyKing.Clone();
            //clone1.Show();

            ////克隆2
            //MonkeyKingPrototype clone2 = monkeyKing.Clone() as Cloned;
            //clone2.Show();

            //Console.ReadKey();

            #endregion

            #region 适配器模式

            //IThreeHole threeHole = new PowerAdapter();
            //threeHole.Request();

            //Console.ReadKey();

            #endregion

            #region 组合模式

            //ComplexGraphics complex = new ComplexGraphics("一个线和圆的复杂图形");
            //Line l = new Line("直线A");
            //Circel c = new Circel("圆A");
            //complex.Add(l);
            //complex.Add(c);
            //complex.Draw();

            //complex.Remove(c);

            //complex.Draw();

            //Console.ReadKey();

            #endregion

            #region 观察者模式

            //VistorPatternMode.VistorPattern.ObjectStructure objectStructure = new VistorPatternMode.VistorPattern.ObjectStructure();
            //foreach (VistorPatternMode.VistorPattern.Element e in objectStructure.Elements)
            //{
            //    // 每个元素接受访问者访问
            //    e.Accept(new VistorPatternMode.VistorPattern.ConcreteVistor());
            //}

            //Console.ReadKey();

            #endregion

            #region 状态者模式

            //Account account = new Account("Adele");

            //account.Deposit(10000.00);

            //account.PayInterest();

            //Console.ReadKey();

            #endregion

            #region 状态者+中介者模式

            //生成玩家对象,并初始化信息
            AbstractCardPartner PlayerA = new PartnerA("A", 20);
            AbstractCardPartner PlayerB = new PartnerB("B", 20);

            //中介者
            AbstractMediator mediator = new MediatorPartner(new InitState());
            //增加玩家
            mediator.Join(PlayerA);
            mediator.Join(PlayerB);

            mediator.gameState = new AWinState(mediator);
            mediator.ChangeMoney(5);

            //结算
            foreach (AbstractCardPartner player in mediator.list)
                Console.WriteLine(player.NickName + " 现在的钱是：{0}", player.Money);


            //Console.ReadKey();

            #endregion
        }
    }
}
