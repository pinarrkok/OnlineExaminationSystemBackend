using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Interceptors
{
    public abstract class MethodInterception: MethodInterceptionBaseAttribute
    {
        // Method çalışmadan sen çalış
        protected virtual void OnBefore(IInvocation invocation) { }
        // Method çalıştıktan sonra sen çalış
        protected virtual void OnAfter(IInvocation invocation) { }
        // Method hata verdiğinde sen çalış
        protected virtual void OnException(IInvocation invocation, System.Exception e) { }
        // Method başarılıysa sen çalış
        protected virtual void OnSuccess(IInvocation invocation) { }
        public override void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {

                isSuccess = false;
                OnException(invocation, e);
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
            }
            OnAfter(invocation);
        }
    }
}
