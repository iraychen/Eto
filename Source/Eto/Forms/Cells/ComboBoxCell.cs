using System;


namespace Eto.Forms
{
	[Handler(typeof(ComboBoxCell.IHandler))]
	public class ComboBoxCell : SingleValueCell<object>
	{
		new IHandler Handler { get { return (IHandler)base.Handler; } }
		
		public ComboBoxCell (int column)
		{
			Binding = new ColumnBinding<object> (column);
		}
		
		public ComboBoxCell (string property)
		{
			Binding = new PropertyBinding (property);
		}

		public ComboBoxCell()
		{
		}

		[Obsolete("Use default constructor instead")]
		public ComboBoxCell (Generator generator)
			: base (generator, typeof(IHandler), true)
		{
		}
		
		public IListStore DataStore {
			get { return Handler.DataStore; }
			set { Handler.DataStore = value; }
		}

		public new interface IHandler : SingleValueCell<object>.IHandler
		{
			IListStore DataStore { get; set; }
		}
	}
}

