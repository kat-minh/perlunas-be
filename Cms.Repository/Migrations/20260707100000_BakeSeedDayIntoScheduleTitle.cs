using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Repository.Migrations
{
    /// <summary>
    /// Web giờ hiển thị tiêu đề lịch trình = đúng ô "Tiêu đề ngày" (bỏ tự động
    /// thêm "Ngày N"). Các dòng SEED lại để số ở trường `Day` riêng nên sẽ mất
    /// số ngày → gộp "Ngày N - " vào `Titile` cho các dòng seed (GUID cccc*/cbbb*)
    /// còn hiệu lực & chưa bắt đầu bằng "Ngày". Bỏ qua dòng admin tự sửa (GUID
    /// ngẫu nhiên) để không đụng nội dung người dùng đã nhập.
    /// </summary>
    public partial class BakeSeedDayIntoScheduleTitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
UPDATE ""Schedules""
SET ""Titile"" = ""Day"" || ' - ' || ""Titile"",
    ""UpdatedAt"" = now()
WHERE ""IsDeleted"" = false
  AND ""Day"" IS NOT NULL AND btrim(""Day"") <> ''
  AND ""Titile"" IS NOT NULL AND ""Titile"" !~* '^\s*ngày'
  AND (""Id""::text LIKE 'cccc%' OR ""Id""::text LIKE 'cbbb%');
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
UPDATE ""Schedules""
SET ""Titile"" = substring(""Titile"" from char_length(""Day"" || ' - ') + 1)
WHERE (""Id""::text LIKE 'cccc%' OR ""Id""::text LIKE 'cbbb%')
  AND ""Titile"" LIKE ""Day"" || ' - %';
");
        }
    }
}
