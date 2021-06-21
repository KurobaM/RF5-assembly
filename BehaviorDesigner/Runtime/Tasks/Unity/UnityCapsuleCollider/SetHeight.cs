using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCapsuleCollider
{
	// Token: 0x02001472 RID: 5234
	[Token(Token = "0x2000E38")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154610", Offset = "0x154711")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154610", Offset = "0x154711")]
	public class SetHeight : Action
	{
		// Token: 0x06007816 RID: 30742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064CA")]
		[Address(RVA = "0x28E0F00", Offset = "0x28E1001", VA = "0x28E0F00", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007817 RID: 30743 RVA: 0x00029CD0 File Offset: 0x00027ED0
		[Token(Token = "0x60064CB")]
		[Address(RVA = "0x28E1000", Offset = "0x28E1101", VA = "0x28E1000", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007818 RID: 30744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064CC")]
		[Address(RVA = "0x28E10F0", Offset = "0x28E11F1", VA = "0x28E10F0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007819 RID: 30745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064CD")]
		[Address(RVA = "0x28E1140", Offset = "0x28E1241", VA = "0x28E1140")]
		public SetHeight()
		{
		}

		// Token: 0x0401BAD3 RID: 113363
		[Token(Token = "0x40184D1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190E70", Offset = "0x190F71")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BAD4 RID: 113364
		[Token(Token = "0x40184D2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190EB0", Offset = "0x190FB1")]
		public SharedFloat direction;

		// Token: 0x0401BAD5 RID: 113365
		[Token(Token = "0x40184D3")]
		[FieldOffset(Offset = "0x60")]
		private CapsuleCollider capsuleCollider;

		// Token: 0x0401BAD6 RID: 113366
		[Token(Token = "0x40184D4")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
