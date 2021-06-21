using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Common
{
	// Token: 0x020011C4 RID: 4548
	[Token(Token = "0x2000B99")]
	[Serializable]
	public class VariableBase
	{
		// Token: 0x06007117 RID: 28951 RVA: 0x00026F28 File Offset: 0x00025128
		[Token(Token = "0x6005DD3")]
		[Address(RVA = "0x20DBB00", Offset = "0x20DBC01", VA = "0x20DBB00", Slot = "4")]
		public virtual bool GetBool()
		{
			return default(bool);
		}

		// Token: 0x06007118 RID: 28952 RVA: 0x00026F40 File Offset: 0x00025140
		[Token(Token = "0x6005DD4")]
		[Address(RVA = "0x20DBB10", Offset = "0x20DBC11", VA = "0x20DBB10", Slot = "5")]
		public virtual int GetInt()
		{
			return 0;
		}

		// Token: 0x06007119 RID: 28953 RVA: 0x00026F58 File Offset: 0x00025158
		[Token(Token = "0x6005DD5")]
		[Address(RVA = "0x20DBB20", Offset = "0x20DBC21", VA = "0x20DBB20", Slot = "6")]
		public virtual float GetFloat()
		{
			return 0f;
		}

		// Token: 0x0600711A RID: 28954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DD6")]
		[Address(RVA = "0x20DBB30", Offset = "0x20DBC31", VA = "0x20DBB30", Slot = "7")]
		public virtual string GetString()
		{
			return null;
		}

		// Token: 0x0600711B RID: 28955 RVA: 0x00026F70 File Offset: 0x00025170
		[Token(Token = "0x6005DD7")]
		[Address(RVA = "0x20DBB80", Offset = "0x20DBC81", VA = "0x20DBB80", Slot = "8")]
		public virtual Vector2 GetVector2()
		{
			return default(Vector2);
		}

		// Token: 0x0600711C RID: 28956 RVA: 0x00026F88 File Offset: 0x00025188
		[Token(Token = "0x6005DD8")]
		[Address(RVA = "0x20DBBF0", Offset = "0x20DBCF1", VA = "0x20DBBF0", Slot = "9")]
		public virtual Vector3 GetVector3()
		{
			return default(Vector3);
		}

		// Token: 0x0600711D RID: 28957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD9")]
		[Address(RVA = "0x20DBC60", Offset = "0x20DBD61", VA = "0x20DBC60")]
		public VariableBase()
		{
		}
	}
}
