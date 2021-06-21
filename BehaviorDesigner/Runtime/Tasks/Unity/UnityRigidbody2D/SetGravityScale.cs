using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x02001394 RID: 5012
	[Token(Token = "0x2000D5F")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F460", Offset = "0x14F561")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F460", Offset = "0x14F561")]
	public class SetGravityScale : Action
	{
		// Token: 0x06007506 RID: 29958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061BA")]
		[Address(RVA = "0x2997F40", Offset = "0x2998041", VA = "0x2997F40", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007507 RID: 29959 RVA: 0x00028860 File Offset: 0x00026A60
		[Token(Token = "0x60061BB")]
		[Address(RVA = "0x2998040", Offset = "0x2998141", VA = "0x2998040", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007508 RID: 29960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061BC")]
		[Address(RVA = "0x2998130", Offset = "0x2998231", VA = "0x2998130", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007509 RID: 29961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061BD")]
		[Address(RVA = "0x2998180", Offset = "0x2998281", VA = "0x2998180")]
		public SetGravityScale()
		{
		}

		// Token: 0x0401B7C5 RID: 112581
		[Token(Token = "0x40181E6")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189120", Offset = "0x189221")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7C6 RID: 112582
		[Token(Token = "0x40181E7")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189160", Offset = "0x189261")]
		public SharedFloat gravityScale;

		// Token: 0x0401B7C7 RID: 112583
		[Token(Token = "0x40181E8")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B7C8 RID: 112584
		[Token(Token = "0x40181E9")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
