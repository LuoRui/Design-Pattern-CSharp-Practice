using System;

namespace DesignPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            #region 创建型模式实践
            // 工厂模式
            FactoryPattern.FactoryPattern.Practice();
            // 抽象工厂模式
            AbstractFactoryPattern.AbstractFactoryPattern.Practice();
            // 单例模式
            SingletonPattern.SingletonPattern.Practice();
            // 建造者模式
            BuilderPattern.BuilderPattern.Practice();
            // 原型模式
            PrototypePattern.PrototypePattern.Practice();
            #endregion

            #region 结构型模式实践
            // 适配器模式
            AdapterPattern.AdapterPattern.Practice();
            // 桥接模式
            BridgePattern.BridgePattern.Practice();
            // 过滤器模式
            FilterPattern.FilterPattern.Practice();
            // 组合模式
            CompositePattern.CompositePattern.Practice();
            // 装饰器模式
            DecoratorPattern.DecoratorPattern.Practice();
            // 外观模式
            FacadePattern.FacadePattern.Practice();
            // 享元模式
            FlyweightPattern.FlyweightPattern.Practice();
            // 代理模式
            ProxyPattern.ProxyPattern.Practice();
            #endregion

            #region 行为型模式实践
            // 责任链模式
            ChainOfResponsibilityPattern.ChainOfResponsibilityPattern.Practice();
            // 命令模式
            CommandPattern.CommandPattern.Practice();
            InterpreterPattern.InterpreterPattern.Practice();
            IteratorPattern.IteratorPattern.Practice();
            MediatorPattern.MediatorPattern.Practice();
            MementoPattern.MementoPattern.Practice();
            ObserverPattern.ObserverPattern.Practice();
            StatePattern.StatePattern.Practice();
            NullObjectPattern.NullObjectPattern.Practice();
            StrategyPattern.StrategyPattern.Practice();
            TemplatePattern.TemplatePattern.Practice();
            VisitorPattern.VisitorPattern.Practice();
            #endregion

            #region J2EE模式实践（C#实现）
            MVCPattern.MVCPattern.Practice();
            BusinessDelegatePattern.BusinessDelegatePattern.Practice();
            CompositeEntityPattern.CompositeEntityPattern.Practice();
            DataAccessObjectPattern.DataAccessObjectPattern.Practice();
            FrontControllerPattern.FrontControllerPattern.Practice();
            InterceptingFilterPattern.InterceptingFilterPattern.Practice();
            ServiceLocatorPattern.ServiceLocatorPattern.Practice();
            TransferObjectPattern.TransferObjectPattern.Practice();
            #endregion
        }
    }
}
