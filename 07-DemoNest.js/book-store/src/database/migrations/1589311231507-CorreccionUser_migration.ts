import {MigrationInterface, QueryRunner} from "typeorm";

export class CorreccionUserMigration1589311231507 implements MigrationInterface {
    name = 'CorreccionUserMigration1589311231507'

    public async up(queryRunner: QueryRunner): Promise<void> {
        await queryRunner.query(`ALTER TABLE "users" RENAME COLUMN "usernombre" TO "username"`, undefined);
        await queryRunner.query(`ALTER TABLE "users" RENAME CONSTRAINT "UQ_7bfc981a98e009146959bc61785" TO "UQ_fe0bb3f6520ee0469504521e710"`, undefined);
    }

    public async down(queryRunner: QueryRunner): Promise<void> {
        await queryRunner.query(`ALTER TABLE "users" RENAME CONSTRAINT "UQ_fe0bb3f6520ee0469504521e710" TO "UQ_7bfc981a98e009146959bc61785"`, undefined);
        await queryRunner.query(`ALTER TABLE "users" RENAME COLUMN "username" TO "usernombre"`, undefined);
    }

}
