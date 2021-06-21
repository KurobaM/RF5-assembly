using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x0200135E RID: 4958
	[Token(Token = "0x2000D29")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E020", Offset = "0x14E121")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E020", Offset = "0x14E121")]
	public class CompareSharedColor : Conditional
	{
		// Token: 0x0600744F RID: 29775 RVA: 0x00028350 File Offset: 0x00026550
		[Token(Token = "0x6006103")]
		[Address(RVA = "0x221F670", Offset = "0x221F771", VA = "0x221F670", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007450 RID: 29776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006104")]
		[Address(RVA = "0x221F710", Offset = "0x221F811", VA = "0x221F710", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007451 RID: 29777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006105")]
		[Address(RVA = "0x221F880", Offset = "0x221F981", VA = "0x221F880")]
		public CompareSharedColor()
		{
		}

		// Token: 0x0401B733 RID: 112435
		[Token(Token = "0x4018154")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187450", Offset = "0x187551")]
		public SharedColor variable;

		// Token: 0x0401B734 RID: 112436
		[Token(Token = "0x4018155")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187490", Offset = "0x187591")]
		public SharedColor compareTo;
	}
}
