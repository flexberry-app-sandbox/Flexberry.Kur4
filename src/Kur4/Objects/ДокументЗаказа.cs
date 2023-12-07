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
    /// Документ заказа.
    /// </summary>
    // *** Start programmer edit section *** (ДокументЗаказа CustomAttributes)

    // *** End programmer edit section *** (ДокументЗаказа CustomAttributes)
    [AutoAltered()]
    [Caption("Документ заказа")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ДокументЗаказаE", new string[] {
            "КодДокумента as \'Код документа\'",
            "ДатаДокумента as \'Дата документа\'",
            "Сумма as \'Сумма\'",
            "ЗаказСобран as \'Заказ собран\'",
            "ЗаказОтправ as \'Заказ отправлен\'",
            "ЗаказПолучен as \'Заказ получен\'",
            "Питание as \'Питание\'",
            "Питание.ВидПитания as \'Питание\'",
            "Контрагенты as \'Контрагенты\'",
            "Контрагенты.КодКонтиагента as \'Код контрагента\'",
            "Сотрудники as \'Сотрудники\'",
            "Сотрудники.КодСотрудника as \'Код сотрудника\'"}, Hidden=new string[] {
            "Питание.ВидПитания",
            "Контрагенты.КодКонтиагента"})]
    [MasterViewDefineAttribute("ДокументЗаказаE", "Питание", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "КодПитания")]
    [MasterViewDefineAttribute("ДокументЗаказаE", "Контрагенты", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    [MasterViewDefineAttribute("ДокументЗаказаE", "Сотрудники", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Фамилия")]
    [View("ДокументЗаказаL", new string[] {
            "КодДокумента as \'Код документа\'",
            "ДатаДокумента as \'Дата документа\'",
            "Сумма as \'Сумма\'",
            "ЗаказСобран as \'Заказ собран\'",
            "ЗаказОтправ as \'Заказ отправлен\'",
            "ЗаказПолучен as \'Заказ получен\'",
            "Питание.ВидПитания as \'Вид питания\'",
            "Контрагенты.КодКонтиагента as \'Код контрагента\'",
            "Сотрудники.КодСотрудника as \'Код сотрудника\'"})]
    public class ДокументЗаказа : ICSSoft.STORMNET.DataObject
    {
        
        private int fКодДокумента;
        
        private System.DateTime fДатаДокумента;
        
        private int fСумма;
        
        private bool fЗаказСобран;
        
        private bool fЗаказОтправ;
        
        private bool fЗаказПолучен;
        
        private IIS.Kur4.Питание fПитание;
        
        private IIS.Kur4.Контрагенты fКонтрагенты;
        
        private IIS.Kur4.Сотрудники fСотрудники;
        
        // *** Start programmer edit section *** (ДокументЗаказа CustomMembers)

        // *** End programmer edit section *** (ДокументЗаказа CustomMembers)

        
        /// <summary>
        /// ДатаДокумента.
        /// </summary>
        // *** Start programmer edit section *** (ДокументЗаказа.ДатаДокумента CustomAttributes)

        // *** End programmer edit section *** (ДокументЗаказа.ДатаДокумента CustomAttributes)
        public virtual System.DateTime ДатаДокумента
        {
            get
            {
                // *** Start programmer edit section *** (ДокументЗаказа.ДатаДокумента Get start)

                // *** End programmer edit section *** (ДокументЗаказа.ДатаДокумента Get start)
                System.DateTime result = this.fДатаДокумента;
                // *** Start programmer edit section *** (ДокументЗаказа.ДатаДокумента Get end)

                // *** End programmer edit section *** (ДокументЗаказа.ДатаДокумента Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокументЗаказа.ДатаДокумента Set start)

                // *** End programmer edit section *** (ДокументЗаказа.ДатаДокумента Set start)
                this.fДатаДокумента = value;
                // *** Start programmer edit section *** (ДокументЗаказа.ДатаДокумента Set end)

                // *** End programmer edit section *** (ДокументЗаказа.ДатаДокумента Set end)
            }
        }
        
        /// <summary>
        /// ЗаказОтправ.
        /// </summary>
        // *** Start programmer edit section *** (ДокументЗаказа.ЗаказОтправ CustomAttributes)

        // *** End programmer edit section *** (ДокументЗаказа.ЗаказОтправ CustomAttributes)
        public virtual bool ЗаказОтправ
        {
            get
            {
                // *** Start programmer edit section *** (ДокументЗаказа.ЗаказОтправ Get start)

                // *** End programmer edit section *** (ДокументЗаказа.ЗаказОтправ Get start)
                bool result = this.fЗаказОтправ;
                // *** Start programmer edit section *** (ДокументЗаказа.ЗаказОтправ Get end)

                // *** End programmer edit section *** (ДокументЗаказа.ЗаказОтправ Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокументЗаказа.ЗаказОтправ Set start)

                // *** End programmer edit section *** (ДокументЗаказа.ЗаказОтправ Set start)
                this.fЗаказОтправ = value;
                // *** Start programmer edit section *** (ДокументЗаказа.ЗаказОтправ Set end)

                // *** End programmer edit section *** (ДокументЗаказа.ЗаказОтправ Set end)
            }
        }
        
        /// <summary>
        /// ЗаказПолучен.
        /// </summary>
        // *** Start programmer edit section *** (ДокументЗаказа.ЗаказПолучен CustomAttributes)

        // *** End programmer edit section *** (ДокументЗаказа.ЗаказПолучен CustomAttributes)
        public virtual bool ЗаказПолучен
        {
            get
            {
                // *** Start programmer edit section *** (ДокументЗаказа.ЗаказПолучен Get start)

                // *** End programmer edit section *** (ДокументЗаказа.ЗаказПолучен Get start)
                bool result = this.fЗаказПолучен;
                // *** Start programmer edit section *** (ДокументЗаказа.ЗаказПолучен Get end)

                // *** End programmer edit section *** (ДокументЗаказа.ЗаказПолучен Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокументЗаказа.ЗаказПолучен Set start)

                // *** End programmer edit section *** (ДокументЗаказа.ЗаказПолучен Set start)
                this.fЗаказПолучен = value;
                // *** Start programmer edit section *** (ДокументЗаказа.ЗаказПолучен Set end)

                // *** End programmer edit section *** (ДокументЗаказа.ЗаказПолучен Set end)
            }
        }
        
        /// <summary>
        /// ЗаказСобран.
        /// </summary>
        // *** Start programmer edit section *** (ДокументЗаказа.ЗаказСобран CustomAttributes)

        // *** End programmer edit section *** (ДокументЗаказа.ЗаказСобран CustomAttributes)
        public virtual bool ЗаказСобран
        {
            get
            {
                // *** Start programmer edit section *** (ДокументЗаказа.ЗаказСобран Get start)

                // *** End programmer edit section *** (ДокументЗаказа.ЗаказСобран Get start)
                bool result = this.fЗаказСобран;
                // *** Start programmer edit section *** (ДокументЗаказа.ЗаказСобран Get end)

                // *** End programmer edit section *** (ДокументЗаказа.ЗаказСобран Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокументЗаказа.ЗаказСобран Set start)

                // *** End programmer edit section *** (ДокументЗаказа.ЗаказСобран Set start)
                this.fЗаказСобран = value;
                // *** Start programmer edit section *** (ДокументЗаказа.ЗаказСобран Set end)

                // *** End programmer edit section *** (ДокументЗаказа.ЗаказСобран Set end)
            }
        }
        
        /// <summary>
        /// КодДокумента.
        /// </summary>
        // *** Start programmer edit section *** (ДокументЗаказа.КодДокумента CustomAttributes)

        // *** End programmer edit section *** (ДокументЗаказа.КодДокумента CustomAttributes)
        public virtual int КодДокумента
        {
            get
            {
                // *** Start programmer edit section *** (ДокументЗаказа.КодДокумента Get start)

                // *** End programmer edit section *** (ДокументЗаказа.КодДокумента Get start)
                int result = this.fКодДокумента;
                // *** Start programmer edit section *** (ДокументЗаказа.КодДокумента Get end)

                // *** End programmer edit section *** (ДокументЗаказа.КодДокумента Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокументЗаказа.КодДокумента Set start)

                // *** End programmer edit section *** (ДокументЗаказа.КодДокумента Set start)
                this.fКодДокумента = value;
                // *** Start programmer edit section *** (ДокументЗаказа.КодДокумента Set end)

                // *** End programmer edit section *** (ДокументЗаказа.КодДокумента Set end)
            }
        }
        
        /// <summary>
        /// Сумма.
        /// </summary>
        // *** Start programmer edit section *** (ДокументЗаказа.Сумма CustomAttributes)

        // *** End programmer edit section *** (ДокументЗаказа.Сумма CustomAttributes)
        public virtual int Сумма
        {
            get
            {
                // *** Start programmer edit section *** (ДокументЗаказа.Сумма Get start)

                // *** End programmer edit section *** (ДокументЗаказа.Сумма Get start)
                int result = this.fСумма;
                // *** Start programmer edit section *** (ДокументЗаказа.Сумма Get end)

                // *** End programmer edit section *** (ДокументЗаказа.Сумма Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокументЗаказа.Сумма Set start)

                // *** End programmer edit section *** (ДокументЗаказа.Сумма Set start)
                this.fСумма = value;
                // *** Start programmer edit section *** (ДокументЗаказа.Сумма Set end)

                // *** End programmer edit section *** (ДокументЗаказа.Сумма Set end)
            }
        }
        
        /// <summary>
        /// Документ заказа.
        /// </summary>
        // *** Start programmer edit section *** (ДокументЗаказа.Контрагенты CustomAttributes)

        // *** End programmer edit section *** (ДокументЗаказа.Контрагенты CustomAttributes)
        [PropertyStorage(new string[] {
                "Контрагенты"})]
        [NotNull()]
        public virtual IIS.Kur4.Контрагенты Контрагенты
        {
            get
            {
                // *** Start programmer edit section *** (ДокументЗаказа.Контрагенты Get start)

                // *** End programmer edit section *** (ДокументЗаказа.Контрагенты Get start)
                IIS.Kur4.Контрагенты result = this.fКонтрагенты;
                // *** Start programmer edit section *** (ДокументЗаказа.Контрагенты Get end)

                // *** End programmer edit section *** (ДокументЗаказа.Контрагенты Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокументЗаказа.Контрагенты Set start)

                // *** End programmer edit section *** (ДокументЗаказа.Контрагенты Set start)
                this.fКонтрагенты = value;
                // *** Start programmer edit section *** (ДокументЗаказа.Контрагенты Set end)

                // *** End programmer edit section *** (ДокументЗаказа.Контрагенты Set end)
            }
        }
        
        /// <summary>
        /// Документ заказа.
        /// </summary>
        // *** Start programmer edit section *** (ДокументЗаказа.Питание CustomAttributes)

        // *** End programmer edit section *** (ДокументЗаказа.Питание CustomAttributes)
        [PropertyStorage(new string[] {
                "Питание"})]
        [NotNull()]
        public virtual IIS.Kur4.Питание Питание
        {
            get
            {
                // *** Start programmer edit section *** (ДокументЗаказа.Питание Get start)

                // *** End programmer edit section *** (ДокументЗаказа.Питание Get start)
                IIS.Kur4.Питание result = this.fПитание;
                // *** Start programmer edit section *** (ДокументЗаказа.Питание Get end)

                // *** End programmer edit section *** (ДокументЗаказа.Питание Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокументЗаказа.Питание Set start)

                // *** End programmer edit section *** (ДокументЗаказа.Питание Set start)
                this.fПитание = value;
                // *** Start programmer edit section *** (ДокументЗаказа.Питание Set end)

                // *** End programmer edit section *** (ДокументЗаказа.Питание Set end)
            }
        }
        
        /// <summary>
        /// Документ заказа.
        /// </summary>
        // *** Start programmer edit section *** (ДокументЗаказа.Сотрудники CustomAttributes)

        // *** End programmer edit section *** (ДокументЗаказа.Сотрудники CustomAttributes)
        [PropertyStorage(new string[] {
                "Сотрудники"})]
        [NotNull()]
        public virtual IIS.Kur4.Сотрудники Сотрудники
        {
            get
            {
                // *** Start programmer edit section *** (ДокументЗаказа.Сотрудники Get start)

                // *** End programmer edit section *** (ДокументЗаказа.Сотрудники Get start)
                IIS.Kur4.Сотрудники result = this.fСотрудники;
                // *** Start programmer edit section *** (ДокументЗаказа.Сотрудники Get end)

                // *** End programmer edit section *** (ДокументЗаказа.Сотрудники Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокументЗаказа.Сотрудники Set start)

                // *** End programmer edit section *** (ДокументЗаказа.Сотрудники Set start)
                this.fСотрудники = value;
                // *** Start programmer edit section *** (ДокументЗаказа.Сотрудники Set end)

                // *** End programmer edit section *** (ДокументЗаказа.Сотрудники Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ДокументЗаказаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ДокументЗаказаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ДокументЗаказаE", typeof(IIS.Kur4.ДокументЗаказа));
                }
            }
            
            /// <summary>
            /// "ДокументЗаказаL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ДокументЗаказаL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ДокументЗаказаL", typeof(IIS.Kur4.ДокументЗаказа));
                }
            }
        }
    }
}
