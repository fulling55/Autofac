//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DomainServicesExample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices;
    using System.ServiceModel.DomainServices.Client;
    using System.ServiceModel.DomainServices.Client.ApplicationServices;
    
    
    /// <summary>
    /// Context for the RIA application.
    /// </summary>
    /// <remarks>
    /// This context extends the base to make application services and types available
    /// for consumption from code and xaml.
    /// </remarks>
    public sealed partial class WebContext : WebContextBase
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the WebContext class.
        /// </summary>
        public WebContext()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the context that is registered as a lifetime object with the current application.
        /// </summary>
        /// <exception cref="InvalidOperationException"> is thrown if there is no current application,
        /// no contexts have been added, or more than one context has been added.
        /// </exception>
        /// <seealso cref="System.Windows.Application.ApplicationLifetimeObjects"/>
        public new static WebContext Current
        {
            get
            {
                return ((WebContext)(WebContextBase.Current));
            }
        }
    }
}
namespace Remember.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel.DomainServices;
    using System.ServiceModel.DomainServices.Client;
    using System.ServiceModel.DomainServices.Client.ApplicationServices;
    
    
    /// <summary>
    /// The 'Task' class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/Remember.Model")]
    public sealed partial class Task : ComplexObject
    {
        
        private int _id;
        
        private bool _isComplete;
        
        private string _title;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnIsCompleteChanging(bool value);
        partial void OnIsCompleteChanged();
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Task"/> class.
        /// </summary>
        public Task()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'Id' value.
        /// </summary>
        [DataMember()]
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnIdChanging(value);
                    this.RaiseDataMemberChanging("Id");
                    this.ValidateProperty("Id", value);
                    this._id = value;
                    this.RaiseDataMemberChanged("Id");
                    this.OnIdChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'IsComplete' value.
        /// </summary>
        [DataMember()]
        public bool IsComplete
        {
            get
            {
                return this._isComplete;
            }
            set
            {
                if ((this._isComplete != value))
                {
                    this.OnIsCompleteChanging(value);
                    this.RaiseDataMemberChanging("IsComplete");
                    this.ValidateProperty("IsComplete", value);
                    this._isComplete = value;
                    this.RaiseDataMemberChanged("IsComplete");
                    this.OnIsCompleteChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'Title' value.
        /// </summary>
        [DataMember()]
        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                if ((this._title != value))
                {
                    this.OnTitleChanging(value);
                    this.RaiseDataMemberChanging("Title");
                    this.ValidateProperty("Title", value);
                    this._title = value;
                    this.RaiseDataMemberChanged("Title");
                    this.OnTitleChanged();
                }
            }
        }
    }
}
namespace Remember.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel;
    using System.ServiceModel.DomainServices;
    using System.ServiceModel.DomainServices.Client;
    using System.ServiceModel.DomainServices.Client.ApplicationServices;
    using Remember.Model;
    
    
    /// <summary>
    /// The DomainContext corresponding to the 'TaskDomainService' DomainService.
    /// </summary>
    public sealed partial class TaskDomainContext : DomainContext
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDomainContext"/> class.
        /// </summary>
        public TaskDomainContext() : 
                this(new WebDomainClient<ITaskDomainServiceContract>(new Uri("Remember-Web-TaskDomainService.svc", UriKind.Relative)))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDomainContext"/> class with the specified service URI.
        /// </summary>
        /// <param name="serviceUri">The TaskDomainService service URI.</param>
        public TaskDomainContext(Uri serviceUri) : 
                this(new WebDomainClient<ITaskDomainServiceContract>(serviceUri))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDomainContext"/> class with the specified <paramref name="domainClient"/>.
        /// </summary>
        /// <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        public TaskDomainContext(DomainClient domainClient) : 
                base(domainClient)
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Asynchronously invokes the 'GetTasks' method of the DomainService.
        /// </summary>
        /// <param name="callback">Callback to invoke when the operation completes.</param>
        /// <param name="userState">Value to pass to the callback.  It can be <c>null</c>.</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        public InvokeOperation<IEnumerable<Task>> GetTasks(Action<InvokeOperation<IEnumerable<Task>>> callback, object userState)
        {
            this.ValidateMethod("GetTasks", null);
            return ((InvokeOperation<IEnumerable<Task>>)(this.InvokeOperation("GetTasks", typeof(IEnumerable<Task>), null, true, callback, userState)));
        }
        
        /// <summary>
        /// Asynchronously invokes the 'GetTasks' method of the DomainService.
        /// </summary>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        public InvokeOperation<IEnumerable<Task>> GetTasks()
        {
            this.ValidateMethod("GetTasks", null);
            return ((InvokeOperation<IEnumerable<Task>>)(this.InvokeOperation("GetTasks", typeof(IEnumerable<Task>), null, true, null, null)));
        }
        
        /// <summary>
        /// Creates a new EntityContainer for this DomainContext's EntitySets.
        /// </summary>
        /// <returns>A new container instance.</returns>
        protected override EntityContainer CreateEntityContainer()
        {
            return new TaskDomainContextEntityContainer();
        }
        
        /// <summary>
        /// Service contract for the 'TaskDomainService' DomainService.
        /// </summary>
        [ServiceContract()]
        public interface ITaskDomainServiceContract
        {
            
            /// <summary>
            /// Asynchronously invokes the 'GetTasks' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/TaskDomainService/GetTasksDomainServiceFault", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/TaskDomainService/GetTasks", ReplyAction="http://tempuri.org/TaskDomainService/GetTasksResponse")]
            IAsyncResult BeginGetTasks(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetTasks'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetTasks'.</param>
            /// <returns>The 'IEnumerable`1' returned from the 'GetTasks' operation.</returns>
            IEnumerable<Task> EndGetTasks(IAsyncResult result);
        }
        
        internal sealed class TaskDomainContextEntityContainer : EntityContainer
        {
            
            public TaskDomainContextEntityContainer()
            {
            }
        }
    }
}
