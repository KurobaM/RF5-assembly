using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector3
{
	// Token: 0x0200130C RID: 4876
	[Token(Token = "0x2000CD9")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C220", Offset = "0x14C321")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C220", Offset = "0x14C321")]
	public class Lerp : Action
	{
		// Token: 0x06007335 RID: 29493 RVA: 0x00027BD0 File Offset: 0x00025DD0
		[Token(Token = "0x6005FE9")]
		[Address(RVA = "0x244A4E0", Offset = "0x244A5E1", VA = "0x244A4E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007336 RID: 29494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FEA")]
		[Address(RVA = "0x244A610", Offset = "0x244A711", VA = "0x244A610", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007337 RID: 29495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FEB")]
		[Address(RVA = "0x244A6D0", Offset = "0x244A7D1", VA = "0x244A6D0")]
		public Lerp()
		{
		}

		// Token: 0x0401B618 RID: 112152
		[Token(Token = "0x4018041")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184210", Offset = "0x184311")]
		public SharedVector3 fromVector3;

		// Token: 0x0401B619 RID: 112153
		[Token(Token = "0x4018042")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184250", Offset = "0x184351")]
		public SharedVector3 toVector3;

		// Token: 0x0401B61A RID: 112154
		[Token(Token = "0x4018043")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184290", Offset = "0x184391")]
		public SharedFloat lerpAmount;

		// Token: 0x0401B61B RID: 112155
		[Token(Token = "0x4018044")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1842D0", Offset = "0x1843D1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1842D0", Offset = "0x1843D1")]
		public SharedVector3 storeResult;
	}
}
