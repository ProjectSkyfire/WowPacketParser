using WowPacketParser.Misc;

namespace WowPacketParser.Enums.Version.V5_4_8_18291
{
    public static class Opcodes_5_4_8
    {
        public static BiDictionary<Opcode, int> Opcodes()
        {
            return Opcs;
        }

        private static readonly BiDictionary<Opcode, int> Opcs = new BiDictionary<Opcode, int>
        {
            {Opcode.CMSG_AREATRIGGER, 0x1C44}, // 18291
            {Opcode.CMSG_AUCTION_HELLO, 0x0379}, // 18291
            {Opcode.CMSG_AUTH_SESSION, 0x00B2}, // 18291
            {Opcode.CMSG_BANKER_ACTIVATE, 0x02E9}, // 18291
            {Opcode.CMSG_BUY_BANK_SLOT, 0x12F2}, // 18291
            {Opcode.CMSG_GAMEOBJ_REPORT_USE, 0x6D9}, // 18291
            {Opcode.CMSG_GAMEOBJ_USE, 0x6D8}, // 18291
            {Opcode.CMSG_GOSSIP_HELLO, 0x12F3}, // 18291
            {Opcode.CMSG_LIST_INVENTORY, 0x02D8}, // 18291
			
            {Opcode.SMSG_AUCTION_HELLO, 0x10A7}, // 18291
            {Opcode.SMSG_AUTH_CHALLENGE, 0x0949}, // 18291
            {Opcode.SMSG_AUTH_RESPONSE, 0x0ABA}, // 18291
            {Opcode.SMSG_CREATURE_QUERY_RESPONSE, 0x048B}, // 18291
            {Opcode.SMSG_DESTROY_OBJECT, 0x14C2}, // 18291
            {Opcode.SMSG_GOSSIP_POI, 0x0785}, // 18291
            {Opcode.SMSG_INITIAL_SPELLS, 0x045A}, // 18291
            {Opcode.SMSG_LOGIN_VERIFY_WORLD, 0x1C0F}, // 18291
            {Opcode.SMSG_SHOW_BANK, 0x0007}, // 18291
            {Opcode.SMSG_NEW_WORLD, 0x1C3B},  // 18291
            {Opcode.SMSG_TRANSFER_PENDING, 0x061B}, // 18291
            {Opcode.SMSG_UPDATE_OBJECT, 0x1792}, // 18291
            
            {Opcode.SMSG_BATTLEPET_ERROR, 0x002F}, // 18291
            {Opcode.SMSG_BATTLEPET_JOURNAL_LOCK, 0x0203}, // 18291
            {Opcode.SMSG_BATTLEPET_UPDATES, 0x041A}, // 18291
            {Opcode.SMSG_BATTLEPET_CAGE_DATE_ERROR, 0x068B}, // 18291
            {Opcode.SMSG_BATTLEPET_RESTORED, 0x0A1A}, // 18291
            {Opcode.SMSG_BATTLEPET_HEALED, 0x0E9E}, // 18291
            {Opcode.SMSG_BATTLEPET_REVOKED, 0x1003}, // 18291
            {Opcode.SMSG_BATTLEPET_NAME_QUERY, 0x1540}, // 18291
            {Opcode.SMSG_BATTLEPET_JOURNAL, 0x1542}, // 18291
            {Opcode.SMSG_BATTLEPET_TRAP_LEVEL, 0x1612}, // 18291
            {Opcode.SMSG_BATTLEPET_LICENSE_UPDATE, 0x162F}, // 18291
            {Opcode.SMSG_BATTLEPET_DELETED, 0x18AB}, // 18291
            {Opcode.SMSG_BATTLEPET_JOURNAL_LOCK_ACQUIRED, 0x1A0F}, // 18291

            {Opcode.SMSG_PETBATTLE_INITIAL_UPDATE, 0x0E1E}, // 18291
            {Opcode.SMSG_PETBATTLE_ROUND_RESULT, 0x0C1A}, // 18291
            {Opcode.SMSG_PETBATTLE_QUEUE_PROPOSE_MATCH, 0x1202}, // 18291
            {Opcode.SMSG_PETBATTLE_SLOT_UPDATE, 0x16AF}, // 18291
            {Opcode.SMSG_PETBATTLE_REPLACEMENT_MADE, 0x1A1A}, // 18291
            {Opcode.SMSG_PETBATTLE_FINAL_ROUND, 0x1C2F}, // 18291
            {Opcode.SMSG_PETBATTLE_PVP_CHALLENGE, 0x1E0B}, // 18291
            {Opcode.SMSG_PETBATTLE_DEBUG_QUEUE_DUMP_RESPONSE, 0x001E}, // 18291
            {Opcode.SMSG_PETBATTLE_QUEUE_STATUS, 0x00A6}, // 18291
            {Opcode.SMSG_PETBATTLE_GAME_LENGTH_WARNING, 0x022B}, // 18291
            {Opcode.SMSG_PETBATTLE_REQUEST_FAILED, 0x022F}, // 18291
            {Opcode.SMSG_PETBATTLE_FINISHED, 0x04BB}, // 18291
            {Opcode.SMSG_PETBATTLE_FIRST_ROUND, 0x0613}, // 18291
            {Opcode.SMSG_PETBATTLE_CHAT_RESTRICTED, 0x06BE}, // 18291
            {Opcode.SMSG_PETBATTLE_FINANLIZE_LOCATION, 0x082E}, // 18291
        };
    }
}
