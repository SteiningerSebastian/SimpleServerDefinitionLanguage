using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleServerDefinitionLanguage
{
    public interface ILanguageInterpreter
    {
        /// <summary>
        /// Interpret the code
        /// </summary>
        public void Interpret();

        /// <summary>
        /// Validate the code
        /// </summary>
        public void Validate();

        /// <summary>
        /// Register a function that can be called in the code.
        /// </summary>
        /// <typeparam name="T">The return type of the function.</typeparam>
        /// <param name="function">The function that should be called.</param>
        public void RegisterFunction<T>(Func<T> function);

        /// <summary>
        /// Register a function that can be called in the code.
        /// </summary>
        /// <typeparam name="T">The return type of the function.</typeparam>
        /// <typeparam name="A">A parameter of the function.</typeparam>
        /// <param name="function">The function that should be called.</param>
        public void RegisterFunction<T, A>(Func<T, A> function);

        /// <summary>
        /// Register a function that can be called in the code.
        /// </summary>
        /// <typeparam name="T">The return type of the function.</typeparam>
        /// <typeparam name="A">A parameter of the function.</typeparam>
        /// <typeparam name="B">A parameter of the function.</typeparam>
        /// <param name="function">The function that should be called.</param>
        public void RegisterFunction<T, A, B>(Func<T, A, B> function);

        /// <summary>
        /// Register a function that can be called in the code.
        /// </summary>
        /// <typeparam name="T">The return type of the function.</typeparam>
        /// <typeparam name="A">A parameter of the function.</typeparam>
        /// <typeparam name="B">A parameter of the function.</typeparam>
        /// <typeparam name="C">A parameter of the function.</typeparam>
        /// <param name="function">The function that should be called.</param>
        public void RegisterFunction<T, A, B, C>(Func<T, A, B, C> function);

        /// <summary>
        /// Register a function that can be called in the code.
        /// </summary>
        /// <typeparam name="T">The return type of the function.</typeparam>
        /// <typeparam name="A">A parameter of the function.</typeparam>
        /// <typeparam name="B">A parameter of the function.</typeparam>
        /// <typeparam name="C">A parameter of the function.</typeparam>
        /// <typeparam name="D">A parameter of the function.</typeparam>
        /// <param name="function">The function that should be called.</param>
        public void RegisterFunction<T, A, B, C, D>(Func<T, A, B, C, D> function);

        /// <summary>
        /// Register a function that can be called in the code.
        /// </summary>
        /// <typeparam name="T">The return type of the function.</typeparam>
        /// <typeparam name="A">A parameter of the function.</typeparam>
        /// <typeparam name="B">A parameter of the function.</typeparam>
        /// <typeparam name="C">A parameter of the function.</typeparam>
        /// <typeparam name="D">A parameter of the function.</typeparam>
        /// <typeparam name="E">A parameter of the function.</typeparam>
        /// <param name="function">The function that should be called.</param>
        public void RegisterFunction<T, A, B, C, D, E>(Func<T, A, B, C, D, E> function);
    }
}
