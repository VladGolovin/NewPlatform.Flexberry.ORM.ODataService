﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.Flexberry.ORM.ODataService.Tests
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Наследник.
    /// </summary>
    // *** Start programmer edit section *** (Наследник CustomAttributes)
    [PublishName("NewPlatform.Flexberry.ORM.ODataService.Tests.DescendantAlias")]
    // *** End programmer edit section *** (Наследник CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class Наследник : NewPlatform.Flexberry.ORM.ODataService.Tests.БазовыйКласс
    {
        
        private double fСвойство;
        
        private NewPlatform.Flexberry.ORM.ODataService.Tests.Мастер fМастер;
        
        private NewPlatform.Flexberry.ORM.ODataService.Tests.Master fMaster;
        
        // *** Start programmer edit section *** (Наследник CustomMembers)

        // *** End programmer edit section *** (Наследник CustomMembers)

        
        /// <summary>
        /// Свойство.
        /// </summary>
        // *** Start programmer edit section *** (Наследник.Свойство CustomAttributes)
        [PublishName("PropertyAlias")]
        // *** End programmer edit section *** (Наследник.Свойство CustomAttributes)
        public virtual double Свойство
        {
            get
            {
                // *** Start programmer edit section *** (Наследник.Свойство Get start)

                // *** End programmer edit section *** (Наследник.Свойство Get start)
                double result = this.fСвойство;
                // *** Start programmer edit section *** (Наследник.Свойство Get end)

                // *** End programmer edit section *** (Наследник.Свойство Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Наследник.Свойство Set start)

                // *** End programmer edit section *** (Наследник.Свойство Set start)
                this.fСвойство = value;
                // *** Start programmer edit section *** (Наследник.Свойство Set end)

                // *** End programmer edit section *** (Наследник.Свойство Set end)
            }
        }
        
        /// <summary>
        /// Наследник.
        /// </summary>
        // *** Start programmer edit section *** (Наследник.Мастер CustomAttributes)
        [PublishName("MasterAlias")]
        // *** End programmer edit section *** (Наследник.Мастер CustomAttributes)
        [PropertyStorage(new string[] {
                "Мастер"})]
        public virtual NewPlatform.Flexberry.ORM.ODataService.Tests.Мастер Мастер
        {
            get
            {
                // *** Start programmer edit section *** (Наследник.Мастер Get start)

                // *** End programmer edit section *** (Наследник.Мастер Get start)
                NewPlatform.Flexberry.ORM.ODataService.Tests.Мастер result = this.fМастер;
                // *** Start programmer edit section *** (Наследник.Мастер Get end)

                // *** End programmer edit section *** (Наследник.Мастер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Наследник.Мастер Set start)

                // *** End programmer edit section *** (Наследник.Мастер Set start)
                this.fМастер = value;
                // *** Start programmer edit section *** (Наследник.Мастер Set end)

                // *** End programmer edit section *** (Наследник.Мастер Set end)
            }
        }
        
        /// <summary>
        /// Наследник.
        /// </summary>
        // *** Start programmer edit section *** (Наследник.Master CustomAttributes)

        // *** End programmer edit section *** (Наследник.Master CustomAttributes)
        [PropertyStorage(new string[] {
                "Master"})]
        public virtual NewPlatform.Flexberry.ORM.ODataService.Tests.Master Master
        {
            get
            {
                // *** Start programmer edit section *** (Наследник.Master Get start)

                // *** End programmer edit section *** (Наследник.Master Get start)
                NewPlatform.Flexberry.ORM.ODataService.Tests.Master result = this.fMaster;
                // *** Start programmer edit section *** (Наследник.Master Get end)

                // *** End programmer edit section *** (Наследник.Master Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Наследник.Master Set start)

                // *** End programmer edit section *** (Наследник.Master Set start)
                this.fMaster = value;
                // *** Start programmer edit section *** (Наследник.Master Set end)

                // *** End programmer edit section *** (Наследник.Master Set end)
            }
        }
    }
}
