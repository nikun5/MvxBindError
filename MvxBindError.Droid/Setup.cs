using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Binding.Bindings.Target.Construction;

namespace MvxBindError.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        /// <summary>
        /// Fill the Binding Factory Registry with bindings from the support library.
        /// </summary>
        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        {
            registry.RegisterCustomBindingFactory<Android.Widget.TextView>(
                               TextSizeTargetBinding.BindableTextSize,
                               textView => new TextSizeTargetBinding(textView));

            MvxAppCompatSetupHelper.FillTargetFactories(registry);

            base.FillTargetFactories(registry);
        }
    }
}
