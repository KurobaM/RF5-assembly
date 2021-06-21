using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector2
{
	// Token: 0x0200131C RID: 4892
	[Token(Token = "0x2000CE8")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C7C0", Offset = "0x14C8C1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C7C0", Offset = "0x14C8C1")]
	public class GetVector3 : Action
	{
		// Token: 0x06007362 RID: 29538 RVA: 0x00027D38 File Offset: 0x00025F38
		[Token(Token = "0x6006016")]
		[Address(RVA = "0x29A04A0", Offset = "0x29A05A1", VA = "0x29A04A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007363 RID: 29539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006017")]
		[Address(RVA = "0x29A0560", Offset = "0x29A0661", VA = "0x29A0560", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007364 RID: 29540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006018")]
		[Address(RVA = "0x29A0620", Offset = "0x29A0721", VA = "0x29A0620")]
		public GetVector3()
		{
		}

		// Token: 0x0401B647 RID: 112199
		[Token(Token = "0x401806C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184D90", Offset = "0x184E91")]
		public SharedVector2 vector3Variable;

		// Token: 0x0401B648 RID: 112200
		[Token(Token = "0x401806D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184DD0", Offset = "0x184ED1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x184DD0", Offset = "0x184ED1")]
		public SharedVector3 storeResult;
	}
}
