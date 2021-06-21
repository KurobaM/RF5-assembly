using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x02001106 RID: 4358
	[Token(Token = "0x2000AF9")]
	public class ObjectChangeTimeWeather : ObjectChangeTime
	{
		// Token: 0x06006E40 RID: 28224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B7F")]
		[Address(RVA = "0x202E1C0", Offset = "0x202E2C1", VA = "0x202E1C0", Slot = "4")]
		public override void UpdateObjectActive(bool value)
		{
		}

		// Token: 0x06006E41 RID: 28225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B80")]
		[Address(RVA = "0x202E400", Offset = "0x202E501", VA = "0x202E400")]
		public ObjectChangeTimeWeather()
		{
		}

		// Token: 0x040180EA RID: 98538
		[Token(Token = "0x4014BC4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Weather[] ValidWeathers;

		// Token: 0x040180EB RID: 98539
		[Token(Token = "0x4014BC5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Season[] ValidSeasons;
	}
}
