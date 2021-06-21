using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013A7 RID: 5031
	[Token(Token = "0x2000D72")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14FBD0", Offset = "0x14FCD1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14FBD0", Offset = "0x14FCD1")]
	public class GetPosition : Action
	{
		// Token: 0x06007552 RID: 30034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006206")]
		[Address(RVA = "0x2991C20", Offset = "0x2991D21", VA = "0x2991C20", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007553 RID: 30035 RVA: 0x00028A28 File Offset: 0x00026C28
		[Token(Token = "0x6006207")]
		[Address(RVA = "0x2991D20", Offset = "0x2991E21", VA = "0x2991D20", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007554 RID: 30036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006208")]
		[Address(RVA = "0x2991E10", Offset = "0x2991F11", VA = "0x2991E10", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007555 RID: 30037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006209")]
		[Address(RVA = "0x2991EA0", Offset = "0x2991FA1", VA = "0x2991EA0")]
		public GetPosition()
		{
		}

		// Token: 0x0401B819 RID: 112665
		[Token(Token = "0x401823A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189D10", Offset = "0x189E11")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B81A RID: 112666
		[Token(Token = "0x401823B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189D50", Offset = "0x189E51")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x189D50", Offset = "0x189E51")]
		public SharedVector3 storeValue;

		// Token: 0x0401B81B RID: 112667
		[Token(Token = "0x401823C")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B81C RID: 112668
		[Token(Token = "0x401823D")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
