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
            // 解释器模式
            InterpreterPattern.InterpreterPattern.Practice();
            // 迭代器模式
            IteratorPattern.IteratorPattern.Practice();
            // 中介者模式
            MediatorPattern.MediatorPattern.Practice();
            // 备忘录模式
            MementoPattern.MementoPattern.Practice();
            // 观察者模式
            ObserverPattern.ObserverPattern.Practice();
            // 状态模式
            StatePattern.StatePattern.Practice();
            // 空对象模式
            NullObjectPattern.NullObjectPattern.Practice();
            // 策略模式
            StrategyPattern.StrategyPattern.Practice();
            // 模板模式
            TemplatePattern.TemplatePattern.Practice();
            // 访问者模式
            VisitorPattern.VisitorPattern.Practice();
            #endregion

            #region J2EE模式实践（C#实现）
            // MVC模式
            MVCPattern.MVCPattern.Practice();
            // 业务代表模式
            BusinessDelegatePattern.BusinessDelegatePattern.Practice();
            // 组合实体模式
            CompositeEntityPattern.CompositeEntityPattern.Practice();
            // 数据访问对象模式
            DataAccessObjectPattern.DataAccessObjectPattern.Practice();
            // 前端控制器模式
            FrontControllerPattern.FrontControllerPattern.Practice();
            // 拦截过滤器模式
            InterceptingFilterPattern.InterceptingFilterPattern.Practice();
            // 服务定位器模式
            ServiceLocatorPattern.ServiceLocatorPattern.Practice();
            // 传输对象模式
            TransferObjectPattern.TransferObjectPattern.Practice();
            #endregion
        }
    }
}
