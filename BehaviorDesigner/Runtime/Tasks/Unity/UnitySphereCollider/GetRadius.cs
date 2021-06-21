using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnitySphereCollider
{
	// Token: 0x0200135A RID: 4954
	[Token(Token = "0x2000D25")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14DEA0", Offset = "0x14DFA1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14DEA0", Offset = "0x14DFA1")]
	public class GetRadius : Action
	{
		// Token: 0x06007440 RID: 29760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F4")]
		[Address(RVA = "0x2998F50", Offset = "0x2999051", VA = "0x2998F50", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007441 RID: 29761 RVA: 0x000282F0 File Offset: 0x000264F0
		[Token(Token = "0x60060F5")]
		[Address(RVA = "0x2999050", Offset = "0x2999151", VA = "0x2999050", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007442 RID: 29762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F6")]
		[Address(RVA = "0x2999140", Offset = "0x2999241", VA = "0x2999140", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007443 RID: 29763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F7")]
		[Address(RVA = "0x2999190", Offset = "0x2999291", VA = "0x2999190")]
		public GetRadius()
		{
		}

		// Token: 0x0401B725 RID: 112421
		[Token(Token = "0x4018146")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187240", Offset = "0x187341")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B726 RID: 112422
		[Token(Token = "0x4018147")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187280", Offset = "0x187381")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x187280", Offset = "0x187381")]
		public SharedFloat storeValue;

		// Token: 0x0401B727 RID: 112423
		[Token(Token = "0x4018148")]
		[FieldOffset(Offset = "0x60")]
		private SphereCollider sphereCollider;

		// Token: 0x0401B728 RID: 112424
		[Token(Token = "0x4018149")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
