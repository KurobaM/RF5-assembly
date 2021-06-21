using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityGameObject
{
	// Token: 0x0200144F RID: 5199
	[Token(Token = "0x2000E15")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1538F0", Offset = "0x1539F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1538F0", Offset = "0x1539F1")]
	public class Instantiate : Action
	{
		// Token: 0x06007791 RID: 30609 RVA: 0x00029970 File Offset: 0x00027B70
		[Token(Token = "0x6006445")]
		[Address(RVA = "0x28E5880", Offset = "0x28E5981", VA = "0x28E5880", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007792 RID: 30610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006446")]
		[Address(RVA = "0x28E59D0", Offset = "0x28E5AD1", VA = "0x28E59D0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007793 RID: 30611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006447")]
		[Address(RVA = "0x28E5AA0", Offset = "0x28E5BA1", VA = "0x28E5AA0")]
		public Instantiate()
		{
		}

		// Token: 0x0401BA52 RID: 113234
		[Token(Token = "0x4018450")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FA90", Offset = "0x18FB91")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA53 RID: 113235
		[Token(Token = "0x4018451")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FAD0", Offset = "0x18FBD1")]
		public SharedVector3 position;

		// Token: 0x0401BA54 RID: 113236
		[Token(Token = "0x4018452")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FB10", Offset = "0x18FC11")]
		public SharedQuaternion rotation;

		// Token: 0x0401BA55 RID: 113237
		[Token(Token = "0x4018453")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18FB50", Offset = "0x18FC51")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FB50", Offset = "0x18FC51")]
		public SharedGameObject storeResult;
	}
}
