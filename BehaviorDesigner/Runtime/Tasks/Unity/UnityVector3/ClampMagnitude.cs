using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector3
{
	// Token: 0x02001302 RID: 4866
	[Token(Token = "0x2000CCF")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14BE60", Offset = "0x14BF61")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14BE60", Offset = "0x14BF61")]
	public class ClampMagnitude : Action
	{
		// Token: 0x06007317 RID: 29463 RVA: 0x00027AE0 File Offset: 0x00025CE0
		[Token(Token = "0x6005FCB")]
		[Address(RVA = "0x24495F0", Offset = "0x24496F1", VA = "0x24495F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007318 RID: 29464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FCC")]
		[Address(RVA = "0x24496E0", Offset = "0x24497E1", VA = "0x24496E0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007319 RID: 29465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FCD")]
		[Address(RVA = "0x24497A0", Offset = "0x24498A1", VA = "0x24497A0")]
		public ClampMagnitude()
		{
		}

		// Token: 0x0401B602 RID: 112130
		[Token(Token = "0x401802B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183BD0", Offset = "0x183CD1")]
		public SharedVector3 vector3Variable;

		// Token: 0x0401B603 RID: 112131
		[Token(Token = "0x401802C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183C10", Offset = "0x183D11")]
		public SharedFloat maxLength;

		// Token: 0x0401B604 RID: 112132
		[Token(Token = "0x401802D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183C50", Offset = "0x183D51")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x183C50", Offset = "0x183D51")]
		public SharedVector3 storeResult;
	}
}
