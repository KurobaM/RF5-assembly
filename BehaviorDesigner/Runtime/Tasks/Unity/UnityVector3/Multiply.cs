using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector3
{
	// Token: 0x0200130E RID: 4878
	[Token(Token = "0x2000CDB")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C2E0", Offset = "0x14C3E1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C2E0", Offset = "0x14C3E1")]
	public class Multiply : Action
	{
		// Token: 0x0600733B RID: 29499 RVA: 0x00027C00 File Offset: 0x00025E00
		[Token(Token = "0x6005FEF")]
		[Address(RVA = "0x244A910", Offset = "0x244AA11", VA = "0x244A910", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600733C RID: 29500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FF0")]
		[Address(RVA = "0x244AA00", Offset = "0x244AB01", VA = "0x244AA00", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600733D RID: 29501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FF1")]
		[Address(RVA = "0x244AAC0", Offset = "0x244ABC1", VA = "0x244AAC0")]
		public Multiply()
		{
		}

		// Token: 0x0401B620 RID: 112160
		[Token(Token = "0x4018049")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184430", Offset = "0x184531")]
		public SharedVector3 vector3Variable;

		// Token: 0x0401B621 RID: 112161
		[Token(Token = "0x401804A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184470", Offset = "0x184571")]
		public SharedFloat multiplyBy;

		// Token: 0x0401B622 RID: 112162
		[Token(Token = "0x401804B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1844B0", Offset = "0x1845B1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1844B0", Offset = "0x1845B1")]
		public SharedVector3 storeResult;
	}
}
