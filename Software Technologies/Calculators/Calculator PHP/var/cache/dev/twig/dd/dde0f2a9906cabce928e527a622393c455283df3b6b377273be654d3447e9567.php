<?php

/* base.html.twig */
class __TwigTemplate_c748bf2aa61eac7f84d3d8cf9b347a1d3f87f721e5937ee0d0d315953517f388 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'header' => array($this, 'block_header'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
            'javascripts' => array($this, 'block_javascripts'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_612da107db81a209b3f35e996aad91f675f453ebb6197bae38d22d0857a4e8f7 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_612da107db81a209b3f35e996aad91f675f453ebb6197bae38d22d0857a4e8f7->enter($__internal_612da107db81a209b3f35e996aad91f675f453ebb6197bae38d22d0857a4e8f7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>";
        // line 11
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 12
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 16
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 19
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">

";
        // line 21
        $this->displayBlock('header', $context, $blocks);
        // line 39
        echo "
<div class=\"container body-container\">
    ";
        // line 41
        $this->displayBlock('body', $context, $blocks);
        // line 48
        echo "</div>


";
        // line 51
        $this->displayBlock('javascripts', $context, $blocks);
        // line 57
        echo "
</body>
</html>
";
        
        $__internal_612da107db81a209b3f35e996aad91f675f453ebb6197bae38d22d0857a4e8f7->leave($__internal_612da107db81a209b3f35e996aad91f675f453ebb6197bae38d22d0857a4e8f7_prof);

    }

    // line 11
    public function block_title($context, array $blocks = array())
    {
        $__internal_d969d912de1c4d51c25d02a4fddd2d69df2c534ca60033e312202ff7a92d8c9d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d969d912de1c4d51c25d02a4fddd2d69df2c534ca60033e312202ff7a92d8c9d->enter($__internal_d969d912de1c4d51c25d02a4fddd2d69df2c534ca60033e312202ff7a92d8c9d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Calculator";
        
        $__internal_d969d912de1c4d51c25d02a4fddd2d69df2c534ca60033e312202ff7a92d8c9d->leave($__internal_d969d912de1c4d51c25d02a4fddd2d69df2c534ca60033e312202ff7a92d8c9d_prof);

    }

    // line 12
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_73dbaa542f778bb7c892511a7b273eaeba4b27ee8296631b974404357085fc52 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_73dbaa542f778bb7c892511a7b273eaeba4b27ee8296631b974404357085fc52->enter($__internal_73dbaa542f778bb7c892511a7b273eaeba4b27ee8296631b974404357085fc52_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 13
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/bootstrap-datetimepicker.min.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_73dbaa542f778bb7c892511a7b273eaeba4b27ee8296631b974404357085fc52->leave($__internal_73dbaa542f778bb7c892511a7b273eaeba4b27ee8296631b974404357085fc52_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_a1868efc91bf7332ccb90db901f60fc268cfd9024cc4c3aa502b14a902fdda13 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a1868efc91bf7332ccb90db901f60fc268cfd9024cc4c3aa502b14a902fdda13->enter($__internal_a1868efc91bf7332ccb90db901f60fc268cfd9024cc4c3aa502b14a902fdda13_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_a1868efc91bf7332ccb90db901f60fc268cfd9024cc4c3aa502b14a902fdda13->leave($__internal_a1868efc91bf7332ccb90db901f60fc268cfd9024cc4c3aa502b14a902fdda13_prof);

    }

    // line 21
    public function block_header($context, array $blocks = array())
    {
        $__internal_61b4e9b0d8278cbcee8510466346da42ec5972d65b7cc943360edadb31b0b1a2 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_61b4e9b0d8278cbcee8510466346da42ec5972d65b7cc943360edadb31b0b1a2->enter($__internal_61b4e9b0d8278cbcee8510466346da42ec5972d65b7cc943360edadb31b0b1a2_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "header"));

        // line 22
        echo "    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"";
        // line 26
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("index");
        echo "\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
";
        
        $__internal_61b4e9b0d8278cbcee8510466346da42ec5972d65b7cc943360edadb31b0b1a2->leave($__internal_61b4e9b0d8278cbcee8510466346da42ec5972d65b7cc943360edadb31b0b1a2_prof);

    }

    // line 41
    public function block_body($context, array $blocks = array())
    {
        $__internal_fa952072dcf84e3193911867f1b640fafb5387d6ddab6e8f4617a88590f4e250 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_fa952072dcf84e3193911867f1b640fafb5387d6ddab6e8f4617a88590f4e250->enter($__internal_fa952072dcf84e3193911867f1b640fafb5387d6ddab6e8f4617a88590f4e250_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 42
        echo "        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                ";
        // line 44
        $this->displayBlock('main', $context, $blocks);
        // line 45
        echo "            </div>
        </div>
    ";
        
        $__internal_fa952072dcf84e3193911867f1b640fafb5387d6ddab6e8f4617a88590f4e250->leave($__internal_fa952072dcf84e3193911867f1b640fafb5387d6ddab6e8f4617a88590f4e250_prof);

    }

    // line 44
    public function block_main($context, array $blocks = array())
    {
        $__internal_f32cce759e570e8a4cc02b846d44572c6b0cca3b7b7faa3aece2d7b5f6d945af = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f32cce759e570e8a4cc02b846d44572c6b0cca3b7b7faa3aece2d7b5f6d945af->enter($__internal_f32cce759e570e8a4cc02b846d44572c6b0cca3b7b7faa3aece2d7b5f6d945af_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_f32cce759e570e8a4cc02b846d44572c6b0cca3b7b7faa3aece2d7b5f6d945af->leave($__internal_f32cce759e570e8a4cc02b846d44572c6b0cca3b7b7faa3aece2d7b5f6d945af_prof);

    }

    // line 51
    public function block_javascripts($context, array $blocks = array())
    {
        $__internal_85524d728084b7bcb4f08e5fd83f57055866f7c245fae565221fea85510869cc = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_85524d728084b7bcb4f08e5fd83f57055866f7c245fae565221fea85510869cc->enter($__internal_85524d728084b7bcb4f08e5fd83f57055866f7c245fae565221fea85510869cc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "javascripts"));

        // line 52
        echo "    <script src=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/jquery-2.2.4.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 53
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/moment.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 54
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 55
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap-datetimepicker.min.js"), "html", null, true);
        echo "\"></script>
";
        
        $__internal_85524d728084b7bcb4f08e5fd83f57055866f7c245fae565221fea85510869cc->leave($__internal_85524d728084b7bcb4f08e5fd83f57055866f7c245fae565221fea85510869cc_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  205 => 55,  201 => 54,  197 => 53,  192 => 52,  186 => 51,  175 => 44,  166 => 45,  164 => 44,  160 => 42,  154 => 41,  134 => 26,  128 => 22,  122 => 21,  111 => 19,  102 => 14,  97 => 13,  91 => 12,  79 => 11,  69 => 57,  67 => 51,  62 => 48,  60 => 41,  56 => 39,  54 => 21,  49 => 19,  42 => 16,  40 => 12,  36 => 11,  29 => 6,);
    }

    public function getSource()
    {
        return "{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>{% block title %}Calculator{% endblock %}</title>
    {% block stylesheets %}
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/bootstrap-datetimepicker.min.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">

{% block header %}
    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"{{ path('index') }}\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
{% endblock %}

<div class=\"container body-container\">
    {% block body %}
        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                {% block main %}{% endblock %}
            </div>
        </div>
    {% endblock %}
</div>


{% block javascripts %}
    <script src=\"{{ asset('js/jquery-2.2.4.min.js') }}\"></script>
    <script src=\"{{ asset('js/moment.min.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap-datetimepicker.min.js') }}\"></script>
{% endblock %}

</body>
</html>
";
    }
}
