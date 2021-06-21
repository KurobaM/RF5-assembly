using System;
using Il2CppDummyDll;

namespace SMG.EzRenamer
{
	// Token: 0x02000C88 RID: 3208
	[Token(Token = "0x2000833")]
	public class EzRR_Messages
	{
		// Token: 0x060052AB RID: 21163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CC")]
		[Address(RVA = "0x1EF5840", Offset = "0x1EF5941", VA = "0x1EF5840")]
		public EzRR_Messages()
		{
		}

		// Token: 0x0400B175 RID: 45429
		[Token(Token = "0x4008510")]
		public const string TITLE_00 = "Attention!";

		// Token: 0x0400B176 RID: 45430
		[Token(Token = "0x4008511")]
		public const string MESSAGE_00 = "Renaming...";

		// Token: 0x0400B177 RID: 45431
		[Token(Token = "0x4008512")]
		public const string MESSAGE_01 = "Sorting...";

		// Token: 0x0400B178 RID: 45432
		[Token(Token = "0x4008513")]
		public const string MESSAGE_02 = "Replacing...";

		// Token: 0x0400B179 RID: 45433
		[Token(Token = "0x4008514")]
		public const string ERROR_00 = "There is no gameobject selected. Please, select one or more gameobjects and try again.";

		// Token: 0x0400B17A RID: 45434
		[Token(Token = "0x4008515")]
		public const string ERROR_01 = "There is no file selected. Please, select one or more files and try again.";

		// Token: 0x0400B17B RID: 45435
		[Token(Token = "0x4008516")]
		public const string ERROR_02 = "To prevent mistakes it isn't possible to rename files with different extensions. Please, select files with the same extensions and try again.";

		// Token: 0x0400B17C RID: 45436
		[Token(Token = "0x4008517")]
		public const string ERROR_03 = "To prevent mistakes it isn't possible to rename with extensions .cs, .js and .shader.";

		// Token: 0x0400B17D RID: 45437
		[Token(Token = "0x4008518")]
		public const string ERROR_04 = "To prevent mistakes it isn't possible to sort gameObjects that has different parents.";

		// Token: 0x0400B17E RID: 45438
		[Token(Token = "0x4008519")]
		public const string ERROR_05 = "To prevent mistakes it isn't possible to sort the children of multiple gameObjects.";

		// Token: 0x0400B17F RID: 45439
		[Token(Token = "0x400851A")]
		public const string ERROR_06 = "Internal Error. GameObject and Object can't be both null.";

		// Token: 0x0400B180 RID: 45440
		[Token(Token = "0x400851B")]
		public const string WARNING_00 = "One or more gameobjects has different parents and this may cause a problem on your Hierarchy. Do want to continue?";

		// Token: 0x0400B181 RID: 45441
		[Token(Token = "0x400851C")]
		public const string WARNING_01 = "It isn't possible to has files with the same name inside Project Folder. Make Sequential has been activated and initial number is 0.";

		// Token: 0x0400B182 RID: 45442
		[Token(Token = "0x400851D")]
		public const string BUTTON_00 = "Close";

		// Token: 0x0400B183 RID: 45443
		[Token(Token = "0x400851E")]
		public const string BUTTON_01 = "Cancel";

		// Token: 0x0400B184 RID: 45444
		[Token(Token = "0x400851F")]
		public const string BUTTON_02 = "Continue";
	}
}
