﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace KoldunTrade
{
    #region Контексты
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    public partial class KoldunModelContainer : ObjectContext
    {
        #region Конструкторы
    
        /// <summary>
        /// Инициализирует новый объект KoldunModelContainer, используя строку соединения из раздела "KoldunModelContainer" файла конфигурации приложения.
        /// </summary>
        public KoldunModelContainer() : base("name=KoldunModelContainer", "KoldunModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Инициализация нового объекта KoldunModelContainer.
        /// </summary>
        public KoldunModelContainer(string connectionString) : base(connectionString, "KoldunModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Инициализация нового объекта KoldunModelContainer.
        /// </summary>
        public KoldunModelContainer(EntityConnection connection) : base(connection, "KoldunModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Разделяемые методы
    
        partial void OnContextCreated();
    
        #endregion
    
    }

    #endregion

}