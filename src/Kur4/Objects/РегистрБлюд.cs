﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Kur4
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Регистр блюд.
    /// </summary>
    // *** Start programmer edit section *** (РегистрБлюд CustomAttributes)

    // *** End programmer edit section *** (РегистрБлюд CustomAttributes)
    [AutoAltered()]
    [Caption("Регистр блюд")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("РегистрБлюдE", new string[] {
            "КодБлюда as \'Код блюда\'",
            "Наименование as \'Наименование\'",
            "Количество as \'Количество\'",
            "Цена as \'Цена\'"})]
    public class РегистрБлюд : ICSSoft.STORMNET.DataObject
    {
        
        private int fКодБлюда;
        
        private string fНаименование;
        
        private int fКоличество;
        
        private int fЦена;
        
        private IIS.Kur4.Питание fПитание;
        
        // *** Start programmer edit section *** (РегистрБлюд CustomMembers)

        // *** End programmer edit section *** (РегистрБлюд CustomMembers)

        
        /// <summary>
        /// КодБлюда.
        /// </summary>
        // *** Start programmer edit section *** (РегистрБлюд.КодБлюда CustomAttributes)

        // *** End programmer edit section *** (РегистрБлюд.КодБлюда CustomAttributes)
        public virtual int КодБлюда
        {
            get
            {
                // *** Start programmer edit section *** (РегистрБлюд.КодБлюда Get start)

                // *** End programmer edit section *** (РегистрБлюд.КодБлюда Get start)
                int result = this.fКодБлюда;
                // *** Start programmer edit section *** (РегистрБлюд.КодБлюда Get end)

                // *** End programmer edit section *** (РегистрБлюд.КодБлюда Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РегистрБлюд.КодБлюда Set start)

                // *** End programmer edit section *** (РегистрБлюд.КодБлюда Set start)
                this.fКодБлюда = value;
                // *** Start programmer edit section *** (РегистрБлюд.КодБлюда Set end)

                // *** End programmer edit section *** (РегистрБлюд.КодБлюда Set end)
            }
        }
        
        /// <summary>
        /// Количество.
        /// </summary>
        // *** Start programmer edit section *** (РегистрБлюд.Количество CustomAttributes)

        // *** End programmer edit section *** (РегистрБлюд.Количество CustomAttributes)
        public virtual int Количество
        {
            get
            {
                // *** Start programmer edit section *** (РегистрБлюд.Количество Get start)

                // *** End programmer edit section *** (РегистрБлюд.Количество Get start)
                int result = this.fКоличество;
                // *** Start programmer edit section *** (РегистрБлюд.Количество Get end)

                // *** End programmer edit section *** (РегистрБлюд.Количество Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РегистрБлюд.Количество Set start)

                // *** End programmer edit section *** (РегистрБлюд.Количество Set start)
                this.fКоличество = value;
                // *** Start programmer edit section *** (РегистрБлюд.Количество Set end)

                // *** End programmer edit section *** (РегистрБлюд.Количество Set end)
            }
        }
        
        /// <summary>
        /// Наименование.
        /// </summary>
        // *** Start programmer edit section *** (РегистрБлюд.Наименование CustomAttributes)

        // *** End programmer edit section *** (РегистрБлюд.Наименование CustomAttributes)
        [StrLen(255)]
        public virtual string Наименование
        {
            get
            {
                // *** Start programmer edit section *** (РегистрБлюд.Наименование Get start)

                // *** End programmer edit section *** (РегистрБлюд.Наименование Get start)
                string result = this.fНаименование;
                // *** Start programmer edit section *** (РегистрБлюд.Наименование Get end)

                // *** End programmer edit section *** (РегистрБлюд.Наименование Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РегистрБлюд.Наименование Set start)

                // *** End programmer edit section *** (РегистрБлюд.Наименование Set start)
                this.fНаименование = value;
                // *** Start programmer edit section *** (РегистрБлюд.Наименование Set end)

                // *** End programmer edit section *** (РегистрБлюд.Наименование Set end)
            }
        }
        
        /// <summary>
        /// Цена.
        /// </summary>
        // *** Start programmer edit section *** (РегистрБлюд.Цена CustomAttributes)

        // *** End programmer edit section *** (РегистрБлюд.Цена CustomAttributes)
        public virtual int Цена
        {
            get
            {
                // *** Start programmer edit section *** (РегистрБлюд.Цена Get start)

                // *** End programmer edit section *** (РегистрБлюд.Цена Get start)
                int result = this.fЦена;
                // *** Start programmer edit section *** (РегистрБлюд.Цена Get end)

                // *** End programmer edit section *** (РегистрБлюд.Цена Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РегистрБлюд.Цена Set start)

                // *** End programmer edit section *** (РегистрБлюд.Цена Set start)
                this.fЦена = value;
                // *** Start programmer edit section *** (РегистрБлюд.Цена Set end)

                // *** End programmer edit section *** (РегистрБлюд.Цена Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Kur4.Питание.
        /// </summary>
        // *** Start programmer edit section *** (РегистрБлюд.Питание CustomAttributes)

        // *** End programmer edit section *** (РегистрБлюд.Питание CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "Питание"})]
        public virtual IIS.Kur4.Питание Питание
        {
            get
            {
                // *** Start programmer edit section *** (РегистрБлюд.Питание Get start)

                // *** End programmer edit section *** (РегистрБлюд.Питание Get start)
                IIS.Kur4.Питание result = this.fПитание;
                // *** Start programmer edit section *** (РегистрБлюд.Питание Get end)

                // *** End programmer edit section *** (РегистрБлюд.Питание Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РегистрБлюд.Питание Set start)

                // *** End programmer edit section *** (РегистрБлюд.Питание Set start)
                this.fПитание = value;
                // *** Start programmer edit section *** (РегистрБлюд.Питание Set end)

                // *** End programmer edit section *** (РегистрБлюд.Питание Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "РегистрБлюдE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View РегистрБлюдE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("РегистрБлюдE", typeof(IIS.Kur4.РегистрБлюд));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of РегистрБлюд.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfРегистрБлюд CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfРегистрБлюд CustomAttributes)
    public class DetailArrayOfРегистрБлюд : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Kur4.DetailArrayOfРегистрБлюд members)

        // *** End programmer edit section *** (IIS.Kur4.DetailArrayOfРегистрБлюд members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type РегистрБлюд by index.
        /// </summary>
        /// <summary>
        /// Adds object with type РегистрБлюд.
        /// </summary>
        public DetailArrayOfРегистрБлюд(IIS.Kur4.Питание fПитание) : 
                base(typeof(РегистрБлюд), ((ICSSoft.STORMNET.DataObject)(fПитание)))
        {
        }
        
        public IIS.Kur4.РегистрБлюд this[int index]
        {
            get
            {
                return ((IIS.Kur4.РегистрБлюд)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Kur4.РегистрБлюд dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
