namespace Core.UI.Elements
{
    public interface IHealthBarComponent
    {
    #region Public Variables

        int MAX   { get; }
        int Value { get; }

    #endregion

    #region Public Methods

        float GetAmount();
        int   GetMax();
        void  SetCurrentValue(int value);
        void  SetMax(int          amount);

    #endregion
    }
}