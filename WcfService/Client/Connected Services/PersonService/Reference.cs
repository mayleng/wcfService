﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.PersonService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PersonService.WcfService")]
    public interface WcfService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WcfService/getName", ReplyAction="http://tempuri.org/WcfService/getNameResponse")]
        string getName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WcfService/getName", ReplyAction="http://tempuri.org/WcfService/getNameResponse")]
        System.Threading.Tasks.Task<string> getNameAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WcfServiceChannel : Client.PersonService.WcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WcfServiceClient : System.ServiceModel.ClientBase<Client.PersonService.WcfService>, Client.PersonService.WcfService {
        
        public WcfServiceClient() {
        }
        
        public WcfServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string getName(string name) {
            return base.Channel.getName(name);
        }
        
        public System.Threading.Tasks.Task<string> getNameAsync(string name) {
            return base.Channel.getNameAsync(name);
        }
    }
}
