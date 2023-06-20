namespace MarkupError.WinUI
{
 using System;

 public class StringResourceXamlMarkupExtension : IMarkupExtension<string>
 {
  private string test;

  public string Test
  {
      get => test;
      set => test = value;
  }

 object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
 {
  return (this as IMarkupExtension<string>).ProvideValue(serviceProvider);
 }

  public string ProvideValue(IServiceProvider serviceProvider)
  {
   return "test";
  }
 }
}
