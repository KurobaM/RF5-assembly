using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector2
{
	// Token: 0x02001315 RID: 4885
	[Token(Token = "0x2000CE1")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C520", Offset = "0x14C621")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C520", Offset = "0x14C621")]
	public class ClampMagnitude : Action
	{
		// Token: 0x0600734D RID: 29517 RVA: 0x00027C90 File Offset: 0x00025E90
		[Token(Token = "0x6006001")]
		[Address(RVA = "0x299FA80", Offset = "0x299FB81", VA = "0x299FA80", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600734E RID: 29518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006002")]
		[Address(RVA = "0x299FB70", Offset = "0x299FC71", VA = "0x299FB70", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600734F RID: 29519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006003")]
		[Address(RVA = "0x299FC30", Offset = "0x299FD31", VA = "0x299FC30")]
		public ClampMagnitude()
		{
		}

		// Token: 0x0401B638 RID: 112184
		[Token(Token = "0x401805D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184960", Offset = "0x184A61")]
		public SharedVector2 vector2Variable;

		// Token: 0x0401B639 RID: 112185
		[Token(Token = "0x401805E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1849A0", Offset = "0x184AA1")]
		public SharedFloat maxLength;

		// Token: 0x0401B63A RID: 112186
		[Token(Token = "0x401805F")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1849E0", Offset = "0x184AE1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1849E0", Offset = "0x184AE1")]
		public SharedVector2 storeResult;
	}
}
