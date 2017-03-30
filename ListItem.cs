
namespace TeacherStarterKit
{
   public class ListItem
   {

      private string m_Text;

      private int m_Value;

      public ListItem(string text, int value)
      {
         m_Text = text;
         m_Value = value;
      }

      public string Text
      {
         get
         {
            return m_Text;
         }
      }

      public int Value
      {
         get
         {
            return m_Value;
         }
      }

      public override string ToString()
      {
         return Text;
      }
   }


}
