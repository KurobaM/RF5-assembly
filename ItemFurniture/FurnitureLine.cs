using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ItemFurniture
{
	// Token: 0x02001045 RID: 4165
	[Token(Token = "0x2000A94")]
	public class FurnitureLine : MonoBehaviour
	{
		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x060068A3 RID: 26787 RVA: 0x00023CD0 File Offset: 0x00021ED0
		[Token(Token = "0x17000A7E")]
		public bool Hit
		{
			[Token(Token = "0x6005727")]
			[Address(RVA = "0x2077310", Offset = "0x2077411", VA = "0x2077310")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060068A4 RID: 26788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005728")]
		[Address(RVA = "0x2077320", Offset = "0x2077421", VA = "0x2077320")]
		private void Start()
		{
		}

		// Token: 0x060068A5 RID: 26789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005729")]
		[Address(RVA = "0x2077500", Offset = "0x2077601", VA = "0x2077500")]
		private void LateUpdate()
		{
		}

		// Token: 0x060068A6 RID: 26790 RVA: 0x00023CE8 File Offset: 0x00021EE8
		[Token(Token = "0x600572A")]
		[Address(RVA = "0x2077550", Offset = "0x2077651", VA = "0x2077550")]
		public bool CheckHit()
		{
			return default(bool);
		}

		// Token: 0x060068A7 RID: 26791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600572B")]
		[Address(RVA = "0x2077A10", Offset = "0x2077B11", VA = "0x2077A10")]
		private void updateLine()
		{
		}

		// Token: 0x060068A8 RID: 26792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600572C")]
		[Address(RVA = "0x2077E20", Offset = "0x2077F21", VA = "0x2077E20")]
		public void SetCollider(BoxCollider collider)
		{
		}

		// Token: 0x060068A9 RID: 26793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600572D")]
		[Address(RVA = "0x2078010", Offset = "0x2078111", VA = "0x2078010")]
		public void OnPut()
		{
		}

		// Token: 0x060068AA RID: 26794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600572E")]
		[Address(RVA = "0x2078040", Offset = "0x2078141", VA = "0x2078040")]
		public FurnitureLine()
		{
		}

		// Token: 0x04017102 RID: 94466
		[Token(Token = "0x4013D80")]
		[FieldOffset(Offset = "0x18")]
		private BoxCollider box;

		// Token: 0x04017103 RID: 94467
		[Token(Token = "0x4013D81")]
		[FieldOffset(Offset = "0x20")]
		private Vector3[] vertex_;

		// Token: 0x04017104 RID: 94468
		[Token(Token = "0x4013D82")]
		[FieldOffset(Offset = "0x28")]
		private LineRenderer lRend;

		// Token: 0x04017105 RID: 94469
		[Token(Token = "0x4013D83")]
		[FieldOffset(Offset = "0x30")]
		private bool isActive;

		// Token: 0x04017106 RID: 94470
		[Token(Token = "0x4013D84")]
		[FieldOffset(Offset = "0x31")]
		private bool isHit;

		// Token: 0x04017107 RID: 94471
		[Token(Token = "0x4013D85")]
		[FieldOffset(Offset = "0x38")]
		private Vector3[] pos_tbl_;
	}
}
