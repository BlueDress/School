<?php

/* base.html.twig */
class __TwigTemplate_93e2499d03c6402ea1e3906495568257ed0120721f7f5badb0e11600e82927c5 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_aebc19c15dd67e2c16ccfe9b6368442f80cf4b1064ce1bfbe2f4548b2bf89e3b = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_aebc19c15dd67e2c16ccfe9b6368442f80cf4b1064ce1bfbe2f4548b2bf89e3b->enter($__internal_aebc19c15dd67e2c16ccfe9b6368442f80cf4b1064ce1bfbe2f4548b2bf89e3b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        $__internal_92d46dcce3ae3681aa6a573f6f74eb1610525e1a2c2ccfef1b879a0bb67cef19 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_92d46dcce3ae3681aa6a573f6f74eb1610525e1a2c2ccfef1b879a0bb67cef19->enter($__internal_92d46dcce3ae3681aa6a573f6f74eb1610525e1a2c2ccfef1b879a0bb67cef19_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <title>";
        // line 10
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 11
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
        // line 20
        $this->displayBlock('body', $context, $blocks);
        // line 23
        echo "</body>
</html>
";
        
        $__internal_aebc19c15dd67e2c16ccfe9b6368442f80cf4b1064ce1bfbe2f4548b2bf89e3b->leave($__internal_aebc19c15dd67e2c16ccfe9b6368442f80cf4b1064ce1bfbe2f4548b2bf89e3b_prof);

        
        $__internal_92d46dcce3ae3681aa6a573f6f74eb1610525e1a2c2ccfef1b879a0bb67cef19->leave($__internal_92d46dcce3ae3681aa6a573f6f74eb1610525e1a2c2ccfef1b879a0bb67cef19_prof);

    }

    // line 10
    public function block_title($context, array $blocks = array())
    {
        $__internal_e07b7735f8bdd6865a084186fed939ae3097e46f2da54908cd0248f3a6ca3b39 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_e07b7735f8bdd6865a084186fed939ae3097e46f2da54908cd0248f3a6ca3b39->enter($__internal_e07b7735f8bdd6865a084186fed939ae3097e46f2da54908cd0248f3a6ca3b39_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_eb84014d996c59c62e9ba59d690764162acbdcb0d34653249cb2c9189dc25318 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_eb84014d996c59c62e9ba59d690764162acbdcb0d34653249cb2c9189dc25318->enter($__internal_eb84014d996c59c62e9ba59d690764162acbdcb0d34653249cb2c9189dc25318_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Project Rider";
        
        $__internal_eb84014d996c59c62e9ba59d690764162acbdcb0d34653249cb2c9189dc25318->leave($__internal_eb84014d996c59c62e9ba59d690764162acbdcb0d34653249cb2c9189dc25318_prof);

        
        $__internal_e07b7735f8bdd6865a084186fed939ae3097e46f2da54908cd0248f3a6ca3b39->leave($__internal_e07b7735f8bdd6865a084186fed939ae3097e46f2da54908cd0248f3a6ca3b39_prof);

    }

    // line 11
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_f32ea4fd3da2857d0e0ef5d5b52943c71aaad5887b61a6c869a26db908f0baff = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_f32ea4fd3da2857d0e0ef5d5b52943c71aaad5887b61a6c869a26db908f0baff->enter($__internal_f32ea4fd3da2857d0e0ef5d5b52943c71aaad5887b61a6c869a26db908f0baff_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        $__internal_c6b68231d0862cdb34aa46b270b61f3ec9cb7ea10247aebb7763559376955620 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c6b68231d0862cdb34aa46b270b61f3ec9cb7ea10247aebb7763559376955620->enter($__internal_c6b68231d0862cdb34aa46b270b61f3ec9cb7ea10247aebb7763559376955620_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 12
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/reset.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 13
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/create-style.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_c6b68231d0862cdb34aa46b270b61f3ec9cb7ea10247aebb7763559376955620->leave($__internal_c6b68231d0862cdb34aa46b270b61f3ec9cb7ea10247aebb7763559376955620_prof);

        
        $__internal_f32ea4fd3da2857d0e0ef5d5b52943c71aaad5887b61a6c869a26db908f0baff->leave($__internal_f32ea4fd3da2857d0e0ef5d5b52943c71aaad5887b61a6c869a26db908f0baff_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_8af5ab14f00d9e236596323f4edf749f8f9db560a6be484d40327111660c1d52 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_8af5ab14f00d9e236596323f4edf749f8f9db560a6be484d40327111660c1d52->enter($__internal_8af5ab14f00d9e236596323f4edf749f8f9db560a6be484d40327111660c1d52_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        $__internal_8cb1c10499ae017b9252d51b006b7b40f6462b57d7a4f5658eb1c20e35a15d02 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8cb1c10499ae017b9252d51b006b7b40f6462b57d7a4f5658eb1c20e35a15d02->enter($__internal_8cb1c10499ae017b9252d51b006b7b40f6462b57d7a4f5658eb1c20e35a15d02_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_8cb1c10499ae017b9252d51b006b7b40f6462b57d7a4f5658eb1c20e35a15d02->leave($__internal_8cb1c10499ae017b9252d51b006b7b40f6462b57d7a4f5658eb1c20e35a15d02_prof);

        
        $__internal_8af5ab14f00d9e236596323f4edf749f8f9db560a6be484d40327111660c1d52->leave($__internal_8af5ab14f00d9e236596323f4edf749f8f9db560a6be484d40327111660c1d52_prof);

    }

    // line 20
    public function block_body($context, array $blocks = array())
    {
        $__internal_a6d4b65f6b9a97505b310ac0820cafcdfde62a45530ee1592a9e89b171b59f04 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_a6d4b65f6b9a97505b310ac0820cafcdfde62a45530ee1592a9e89b171b59f04->enter($__internal_a6d4b65f6b9a97505b310ac0820cafcdfde62a45530ee1592a9e89b171b59f04_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_cd119bc7295034cc5c276fe8713020cd56507e31abb45e95ccf5e47e97d02470 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_cd119bc7295034cc5c276fe8713020cd56507e31abb45e95ccf5e47e97d02470->enter($__internal_cd119bc7295034cc5c276fe8713020cd56507e31abb45e95ccf5e47e97d02470_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 21
        echo "    ";
        $this->displayBlock('main', $context, $blocks);
        
        $__internal_cd119bc7295034cc5c276fe8713020cd56507e31abb45e95ccf5e47e97d02470->leave($__internal_cd119bc7295034cc5c276fe8713020cd56507e31abb45e95ccf5e47e97d02470_prof);

        
        $__internal_a6d4b65f6b9a97505b310ac0820cafcdfde62a45530ee1592a9e89b171b59f04->leave($__internal_a6d4b65f6b9a97505b310ac0820cafcdfde62a45530ee1592a9e89b171b59f04_prof);

    }

    public function block_main($context, array $blocks = array())
    {
        $__internal_b072303cd48db863017520cd70242550a76441353c6485cbf56c7a85d079f490 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_b072303cd48db863017520cd70242550a76441353c6485cbf56c7a85d079f490->enter($__internal_b072303cd48db863017520cd70242550a76441353c6485cbf56c7a85d079f490_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_486ed9b2f6077aebe6d86c5b70b2411b5ce087c261e9df6e12e80711c13b6a91 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_486ed9b2f6077aebe6d86c5b70b2411b5ce087c261e9df6e12e80711c13b6a91->enter($__internal_486ed9b2f6077aebe6d86c5b70b2411b5ce087c261e9df6e12e80711c13b6a91_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_486ed9b2f6077aebe6d86c5b70b2411b5ce087c261e9df6e12e80711c13b6a91->leave($__internal_486ed9b2f6077aebe6d86c5b70b2411b5ce087c261e9df6e12e80711c13b6a91_prof);

        
        $__internal_b072303cd48db863017520cd70242550a76441353c6485cbf56c7a85d079f490->leave($__internal_b072303cd48db863017520cd70242550a76441353c6485cbf56c7a85d079f490_prof);

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
        return array (  141 => 21,  132 => 20,  115 => 19,  103 => 14,  99 => 13,  94 => 12,  85 => 11,  67 => 10,  55 => 23,  53 => 20,  49 => 19,  42 => 16,  40 => 11,  36 => 10,  30 => 6,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <title>{% block title %}Project Rider{% endblock %}</title>
    {% block stylesheets %}
        <link rel=\"stylesheet\" href=\"{{ asset('css/reset.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/create-style.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">
{% block body %}
    {% block main %}{% endblock %}
{% endblock %}
</body>
</html>
", "base.html.twig", "C:\\Exam 03-Jan-2018\\PHP-Skeleton\\app\\Resources\\views\\base.html.twig");
    }
}
