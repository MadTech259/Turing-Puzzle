public interface ISymbolsStripController
{
    Symbol GetSymbolAt(int i);
    void WriteSymbolAt(int i, Symbol s);
}