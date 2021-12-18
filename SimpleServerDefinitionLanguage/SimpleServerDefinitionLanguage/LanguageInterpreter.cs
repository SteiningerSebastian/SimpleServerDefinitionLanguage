namespace SimpleServerDefinitionLanguage
{
    public class LanguageInterpreter:ILanguageInterpreter
    {
        public LanguageInterpreter()
        {

        }

        public void Interpret()
        {
            throw new NotImplementedException();
        }

        public void RegisterFunction<T>(Func<T> function)
        {
            throw new NotImplementedException();
        }

        public void RegisterFunction<T, A>(Func<T, A> function)
        {
            throw new NotImplementedException();
        }

        public void RegisterFunction<T, A, B>(Func<T, A, B> function)
        {
            throw new NotImplementedException();
        }

        public void RegisterFunction<T, A, B, C>(Func<T, A, B, C> function)
        {
            throw new NotImplementedException();
        }

        public void RegisterFunction<T, A, B, C, D>(Func<T, A, B, C, D> function)
        {
            throw new NotImplementedException();
        }

        public void RegisterFunction<T, A, B, C, D, E>(Func<T, A, B, C, D, E> function)
        {
            throw new NotImplementedException();
        }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}