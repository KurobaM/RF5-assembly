using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityGameObject
{
	// Token: 0x02001447 RID: 5191
	[Token(Token = "0x2000E0D")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1535F0", Offset = "0x1536F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1535F0", Offset = "0x1536F1")]
	public class CompareTag : Conditional
	{
		// Token: 0x06007779 RID: 30585 RVA: 0x000298B0 File Offset: 0x00027AB0
		[Token(Token = "0x600642D")]
		[Address(RVA = "0x28E4E10", Offset = "0x28E4F11", VA = "0x28E4E10", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600777A RID: 30586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600642E")]
		[Address(RVA = "0x28E4EC0", Offset = "0x28E4FC1", VA = "0x28E4EC0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600777B RID: 30587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600642F")]
		[Address(RVA = "0x28E4F30", Offset = "0x28E5031", VA = "0x28E4F30")]
		public CompareTag()
		{
		}

		// Token: 0x0401BA41 RID: 113217
		[Token(Token = "0x401843F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F600", Offset = "0x18F701")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA42 RID: 113218
		[Token(Token = "0x4018440")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F640", Offset = "0x18F741")]
		public SharedString tag;
	}
}
