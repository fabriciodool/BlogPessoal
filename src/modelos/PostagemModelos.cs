using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogPessoal.src.modelos
{
    [Table("tb_postagens")]
    public class PostagemModelos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        [ForeignKey("fk_usuario")]
        public UsuarioModelo Criador { get; set; }

        [ForeignKey("fk_tema")]
        public TemaModelo Tema { get; set; }



    }
}