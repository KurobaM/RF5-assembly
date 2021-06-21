using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FD7 RID: 4055
	[Token(Token = "0x2000A2F")]
	public sealed class ChildDataFormatter : IMessagePackFormatter<ChildData>, IMessagePackFormatter
	{
		// Token: 0x06006671 RID: 26225 RVA: 0x000224A0 File Offset: 0x000206A0
		[Token(Token = "0x600550B")]
		[Address(RVA = "0x25FC610", Offset = "0x25FC711", VA = "0x25FC610")]
		private static System.ReadOnlySpan<byte> GetSpan_Name()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006672 RID: 26226 RVA: 0x000224B8 File Offset: 0x000206B8
		[Token(Token = "0x600550C")]
		[Address(RVA = "0x25FC680", Offset = "0x25FC781", VA = "0x25FC680")]
		private static System.ReadOnlySpan<byte> GetSpan_IsMale()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006673 RID: 26227 RVA: 0x000224D0 File Offset: 0x000206D0
		[Token(Token = "0x600550D")]
		[Address(RVA = "0x25FC6F0", Offset = "0x25FC7F1", VA = "0x25FC6F0")]
		private static System.ReadOnlySpan<byte> GetSpan_Personality()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006674 RID: 26228 RVA: 0x000224E8 File Offset: 0x000206E8
		[Token(Token = "0x600550E")]
		[Address(RVA = "0x25FC760", Offset = "0x25FC861", VA = "0x25FC760")]
		private static System.ReadOnlySpan<byte> GetSpan_BirthDay()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006675 RID: 26229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600550F")]
		[Address(RVA = "0x25FC7D0", Offset = "0x25FC8D1", VA = "0x25FC7D0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, ChildData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006676 RID: 26230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005510")]
		[Address(RVA = "0x25FCB20", Offset = "0x25FCC21", VA = "0x25FCB20", Slot = "5")]
		public ChildData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x06006677 RID: 26231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005511")]
		[Address(RVA = "0x25FD0D0", Offset = "0x25FD1D1", VA = "0x25FD0D0")]
		public ChildDataFormatter()
		{
		}
	}
}
