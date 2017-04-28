namespace WebAssembly.Instructions
{
	/// <summary>
	/// (Placeholder) Instruction for Int32LessThanSigned.
	/// </summary>
	public class Int32LessThanSigned : Instruction
	{
		/// <summary>
		/// Always <see cref="OpCode.Int32LessThanSigned"/>.
		/// </summary>
		public sealed override OpCode OpCode => OpCode.Int32LessThanSigned;

		/// <summary>
		/// Creates a new  <see cref="Int32LessThanSigned"/> instance.
		/// </summary>
		public Int32LessThanSigned()
		{
		}
	}
}