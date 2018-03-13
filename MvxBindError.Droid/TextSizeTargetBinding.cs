using Android.Widget;
using MvvmCross.Binding.Droid.Target;

namespace MvxBindError.Droid
{
    public class TextSizeTargetBinding : MvxAndroidTargetBinding<TextView, float>
    {
        public const string BindableTextSize = "BindableTextSize";

        public TextSizeTargetBinding(TextView target)
            : base(target)
        {
        }

        protected override void SetValueImpl(TextView textView, float size)
        {
            textView.SetTextSize(Android.Util.ComplexUnitType.Sp, size);
        }
    }
}